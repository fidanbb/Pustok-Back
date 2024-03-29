﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Pustok_Backend.Areas.Admin.ViewModels.Account;
using Pustok_Backend.Data;
using Pustok_Backend.Helpers.Enums;
using Pustok_Backend.Models;
using Pustok_Backend.Services.Interfaces;
using Pustok_Backend.ViewModels.Account;
using Pustok_Backend.ViewModels.Cart;
using Pustok_Backend.ViewModels.Wishlist;

namespace Pustok_Backend.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailService _emailService;
        private readonly IWishlistService _wishlistService;
        private readonly AppDbContext _context;
        private readonly ICartService _cartService;

        public AccountController(UserManager<AppUser> userManager,
                                 SignInManager<AppUser> signInManager,
                                 RoleManager<IdentityRole> roleManager,
                                 IEmailService emailService,
                                 IWishlistService wishlistService,
                                 AppDbContext context,
                                 ICartService cartService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _emailService = emailService;
            _wishlistService = wishlistService;
            _context = context;
            _cartService = cartService;
        }


        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            AppUser user = new()
            {
                Name=request.Name,
                Surname=request.Surname,
                Email = request.Email,
                UserName = request.Username,
            };


            IdentityResult result = await _userManager.CreateAsync(user, request.Password);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, item.Description);
                }

                return View(request);
            }

            var createdUser = await _userManager.FindByNameAsync(user.UserName);

            await _userManager.AddToRoleAsync(createdUser, Roles.Member.ToString());

            TempData["Email"] = createdUser.Email;

            string token = await _userManager.GenerateEmailConfirmationTokenAsync(user);

            var url = Url.Action(nameof(ConfirmEmail), "Account", new { userId = user.Id, token }, Request.Scheme, Request.Host.ToString());

            string subject = "Welcome to Pustok";
            string emailHtml = string.Empty;

            using (StreamReader reader = new("wwwroot/templates/register-verify.html"))
            {
                emailHtml = reader.ReadToEnd();
            }
            string base64 = "https://imageio.forbes.com/specials-images/imageserve/5f85be4ed0acaafe77436710/0x0.jpg?format=jpg&height=900&width=1600&fit=bounds";
            emailHtml = emailHtml.Replace("{{link}}", url);
            emailHtml = emailHtml.Replace("{{test}}", base64);

            emailHtml = emailHtml.Replace("{{name}}", user.Name);
            emailHtml = emailHtml.Replace("{{surname}}", user.Surname);


            _emailService.Send(user.Email, subject, emailHtml);

            return RedirectToAction(nameof(VerifyEmail));
        }


        public async Task<IActionResult> ConfirmEmail(string userId, string token)
        {
            try
            {
                if (userId is null || token is null) throw new ArgumentNullException();

                AppUser user = await _userManager.FindByIdAsync(userId);

                if (user is null) throw new NullReferenceException();

                await _userManager.ConfirmEmailAsync(user, token);

                await _signInManager.SignInAsync(user, false);

                return RedirectToAction("Index", "Home");
            }
            catch (ArgumentNullException)
            {
                return BadRequest();
            }

            catch (NullReferenceException)
            {
                return NotFound();
            }

        }

        public IActionResult VerifyEmail()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM request)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            AppUser dbUser = await _userManager.FindByEmailAsync(request.EmailOrUsername);

            if (dbUser is null)
            {
                dbUser = await _userManager.FindByNameAsync(request.EmailOrUsername);
            }

            if (dbUser is null)
            {
                ModelState.AddModelError(string.Empty, "Login informations is wrong");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(dbUser, request.Password, request.IsRememberMe, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError(string.Empty, "Login informations is wrong");
                return View();
            }
            List<WishlistVM> wishlist = new();
            Wishlist dbWishlist = await _wishlistService.GetWishlistByUserIdAsync(dbUser.Id);

            if (dbWishlist is not null)
            {
                List<WishlistProduct> wishlistProducts = await _wishlistService.GetAllByWishlistIdAsync(dbWishlist.Id);

                foreach (var item in wishlistProducts)
                {
                    wishlist.Add(new WishlistVM
                    {
                        ProductId = item.ProductId
                    });
                } 

                Response.Cookies.Append("wishlist", JsonConvert.SerializeObject(wishlist));

            }

            List<CartVM> basket = new();
            Cart dbBasket = await _cartService.GetCartByUserIdAsync(dbUser.Id);

            if (dbBasket is not null)
            {
                List<CartProduct> basketProducts = await _cartService.GetAllByBasketIdAsync(dbBasket.Id);

                foreach (var item in basketProducts)
                {
                    basket.Add(new CartVM
                    {
                        Id = item.ProductId,
                        Count = item.Count
                    });
                }

                Response.Cookies.Append("basket", JsonConvert.SerializeObject(basket));

            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout(string userId)
        {
            await _signInManager.SignOutAsync();
            List<WishlistVM> wishlist = _wishlistService.GetDatasFromCookies();
            Wishlist dbWishlist = await _wishlistService.GetWishlistByUserIdAsync(userId);

            if (wishlist.Count != 0)
            {
                if (dbWishlist == null)
                {
                    dbWishlist = new()
                    {
                        AppUserId = userId,
                        WishlistProducts = new List<WishlistProduct>()

                    };

                    foreach (var item in wishlist)
                    {
                        dbWishlist.WishlistProducts.Add(new WishlistProduct()
                        {
                            ProductId = item.ProductId,
                            WishlistId = dbWishlist.Id
                        });
                    }

                    await _context.Wishlists.AddAsync(dbWishlist);
                    await _context.SaveChangesAsync();
                }
                else
                {
                    List<WishlistProduct> wishlistProducts = new();

                    foreach (var item in wishlist)
                    {
                        wishlistProducts.Add(new WishlistProduct()
                        {
                            ProductId = item.ProductId,
                            WishlistId = dbWishlist.Id
                        });
                    }

                    dbWishlist.WishlistProducts = wishlistProducts;

                    _context.SaveChanges();

                }

                Response.Cookies.Delete("wishlist");
            }
            else
            {
                if (dbWishlist is not null)
                {
                    _context.Wishlists.Remove(dbWishlist);
                    _context.SaveChanges();
                }

            }


            List<CartVM> basket = _cartService.GetDatasFromCookies();
            Cart dbBasket = await _cartService.GetCartByUserIdAsync(userId);

            if (basket.Count != 0)
            {
                if (dbBasket == null)
                {
                    dbBasket = new()
                    {
                        AppUserId = userId,
                        CartProducts = new List<CartProduct>()
                    };

                    foreach (var item in basket)
                    {
                        dbBasket.CartProducts.Add(new CartProduct()
                        {
                            ProductId = item.Id,
                            CartId = dbBasket.Id,
                            Count = item.Count
                        });
                    }
                    await _context.Carts.AddAsync(dbBasket);
                    await _context.SaveChangesAsync();

                }
                else
                {
                    List<CartProduct> basketProducts = new();

                    foreach (var item in basket)
                    {
                        basketProducts.Add(new CartProduct()
                        {
                            ProductId = item.Id,
                            CartId = dbBasket.Id,
                            Count = item.Count
                        });
                    }

                    dbBasket.CartProducts = basketProducts;
                    _context.SaveChanges();
                }

                Response.Cookies.Delete("basket");
            }
            else
            {
                if (dbBasket is not null)
                {
                    _context.Carts.Remove(dbBasket);
                    _context.SaveChanges();
                }

            }


            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordVM model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            AppUser existUser = await _userManager.FindByEmailAsync(model.Email);

            if (existUser is null)
            {
                ModelState.AddModelError("Email", "User is not found.");

                return View();
            }

            TempData["Email"] = existUser.Email;

            string token = await _userManager.GeneratePasswordResetTokenAsync(existUser);
            string link = Url.Action(nameof(ResetPassword), "Account", new { userId = existUser.Id, token }, Request.Scheme, Request.Host.ToString());
            string subject = "Reset Password";
            string html;

            using (StreamReader reader = new StreamReader("wwwroot/templates/reset-password.html"))
            {
                html = reader.ReadToEnd();
            }

            string fullName = existUser.Name + " "+existUser.Surname;

            html = html.Replace("{{fullName}}", fullName);
            html = html.Replace("{{link}}", link);

            _emailService.Send(existUser.Email, subject, html);

            return RedirectToAction(nameof(VerifyResetPassword));
        }

        [HttpGet]
        public IActionResult VerifyResetPassword()
        {
            return View();
        }


        [HttpGet]
        public IActionResult ResetPassword(string userId, string token)
        {
            return View(new ResetPasswordVM { Token = token, UserId = userId });
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ResetPassword(ResetPasswordVM resetPassword)
        {
            try
            {
                if (!ModelState.IsValid) return View(resetPassword);
                AppUser existUser = await _userManager.FindByIdAsync(resetPassword.UserId);
                if (existUser == null) throw new NullReferenceException();

                if (await _userManager.CheckPasswordAsync(existUser, resetPassword.Password))
                {
                    ModelState.AddModelError("", "New password cant be same with old password");
                    return View(resetPassword);
                }
                await _userManager.ResetPasswordAsync(existUser, resetPassword.Token, resetPassword.Password);
                return RedirectToAction(nameof(Login));
            }
            catch (ArgumentNullException)
            {
                return BadRequest();
            }

            catch (NullReferenceException)
            {
                return NotFound();
            }
          
        }




        //create roles

        //[HttpGet]
        //public async Task<IActionResult> CreateRoles()
        //{
        //    foreach (var role in Enum.GetValues(typeof(Roles)))
        //    {
        //        if (!await _roleManager.RoleExistsAsync(role.ToString()))
        //        {
        //            await _roleManager.CreateAsync(new IdentityRole { Name = role.ToString() });
        //        }
        //    }
        //    return Ok();
        //}

    }
}
