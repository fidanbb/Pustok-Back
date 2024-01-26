using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pustok_Backend.Models;

namespace Pustok_Backend.Data
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Advert> Adverts { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Setting>Settings { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Subscribe> Subscribes { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        public DbSet<BlogAuthor> BlogAuthors { get; set; }
        public DbSet<BlogImage> BlogImages { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<WishlistProduct> WishlistProducts { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartProduct> CartProducts { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Service>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Advert>().HasQueryFilter(m => !m.SoftDeleted);

            modelBuilder.Entity<Brand>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Setting>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Social>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Subscribe>().HasQueryFilter(m => !m.SoftDeleted);

            modelBuilder.Entity<ContactMessage>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Testimonial>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Blog>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<BlogAuthor>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<BlogComment>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<BlogImage>().HasQueryFilter(m => !m.SoftDeleted);

            modelBuilder.Entity<BlogTag>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Tag>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<ProductImage>().HasQueryFilter(m => !m.SoftDeleted);

            modelBuilder.Entity<Product>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Author>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<ProductComment>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<ProductImage>().HasQueryFilter(m => !m.SoftDeleted);

            modelBuilder.Entity<ProductTag>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Discount>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Category>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Wishlist>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<WishlistProduct>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<Cart>().HasQueryFilter(m => !m.SoftDeleted);
            modelBuilder.Entity<CartProduct>().HasQueryFilter(m => !m.SoftDeleted);



            modelBuilder.Entity<Slider>().HasData(
          new Slider { Id = 1, Image = "home-slider-1-ai.webp", Header = "J.D. Kurtness", Title = "De Vengeance", Description = " Cover Up Front Of Books and Leave Summary",DirectionId=1, SoftDeleted = false },
          new Slider { Id = 2, Image = "home-slider-2-ai.webp", Header = "H.G. Wells", Title = "De Vengeance", Description = "Cover Up Front Of Books and Leave Summary",DirectionId=2, SoftDeleted = false }

      );

            modelBuilder.Entity<Direction>().HasData(
                new Direction { Id = 1, Name = "right" },
                new Direction { Id = 2, Name = "left" }
                );

            modelBuilder.Entity<Service>().HasData(

                new Service { Id=1,Title= "Free Shipping Item", Description= "Orders over $500", IconName= "fas fa-shipping-fast" },
               new Service { Id = 2, Title = "Money Back Guarantee", Description = "100% money back", IconName = "fas fa-redo-alt" }, 
               new Service { Id = 3, Title = "Cash On Delivery", Description = "Lorem ipsum dolor amet", IconName = "fas fa-piggy-bank" },

                     new Service { Id = 4, Title = "Help & Support", Description = "Call us : + 0123.4567.89", IconName = "fas fa-life-ring" }

                );

            modelBuilder.Entity<Advert>().HasData(
                new Advert { Id=1,Image= "promo-banner-with-text.webp" },
                new Advert { Id =2, Image = "promo-banner-with-text-2.webp" },
                new Advert { Id = 3, Image = "promo-banner-mid.webp", Header= "Buy 3. Get Free 1.", Title= "50% off for selected products in Pustok." },
                new Advert { Id = 4, Image = "promo-banner-small.webp", Header = "$26.00", Title = "Praise for The Night Child" },
                new Advert { Id = 5, Image = "promo-banner-full.webp", Header = "I Love This Idea!", Title = "Cover up front of book and leave summary" }
                );

            modelBuilder.Entity<Brand>().HasData(
                new Brand { Id=1,Image= "brand-1.webp" },
                new Brand { Id = 2, Image = "brand-2.webp" },
                new Brand { Id = 3, Image = "brand-3.webp" },
                new Brand { Id = 4, Image = "brand-4.webp" },
                new Brand { Id = 5, Image = "brand-5.webp" },
                new Brand { Id = 6, Image = "brand-6.webp" }
                );

            modelBuilder.Entity<Setting>().HasData(
                new Setting { Id=1,Key="HeaderLogo",Value= "logo.webp" },
                new Setting { Id=2,Key="FooterLogo",Value= "logo--footer.webp" },
                new Setting { Id = 3, Key = "Address", Value = "7/135 Saint St. London" },
                new Setting { Id = 4, Key = "Phone", Value = "+18088 234 5678" },
                new Setting { Id = 5, Key = "Email", Value = "support@hastech.com" },
                new Setting { Id = 6, Key = "PaymentMethod", Value = "payment.webp" },
                new Setting { Id = 7, Key = "Address2", Value = "1130/5 Louis III St. New York" },
                new Setting { Id = 8, Key = "Phone2", Value = "+18088 625 4251" },
                new Setting { Id = 9, Key = "Email2", Value = "info@lawyersattorneys.com" }
                );

            modelBuilder.Entity<Social>().HasData(
                new Social { Id=1,IconName= "fa-brands fa-facebook-f", Link= "https://www.facebook.com/" },
                new Social { Id = 2, IconName = "fa-brands fa-twitter", Link = "https://twitter.com/" },
                new Social { Id = 3, IconName = "fa-brands fa-google", Link = "https://www.google.com/" },
                new Social { Id = 4, IconName = "fa-brands fa-youtube", Link = "https://www.youtube.com/" }
                );


            modelBuilder.Entity<Subscribe>().HasData(
                new Subscribe { Id = 1,Email="surac@gmail.com"},
                new Subscribe { Id = 2, Email = "kubra@gmail.com" }
                );



            modelBuilder.Entity<ContactMessage>().HasData(
                new ContactMessage { Id = 1, Name = "Fidan Bashirova", Email = "fidanbb@code.edu.az", Message = "Helllooo" }
                );


            modelBuilder.Entity<Testimonial>().HasData(
                
                new Testimonial { Id=1,Review= " Discovered Pustok, a reader's paradise! Vast collection caters to every literary taste. User-friendly interface made browsing a delight. Quick shipping, excellent customer service – my go-to online bookstore.", AppUserId= "0efd01de-4eec-45ff-9de4-f03f9abdf104" },
                new Testimonial { Id = 2, Review = "Explored numerous online bookstores, but this one stands out. Curated selection, easy navigation – a reader's haven. Intuitive layout, discover new titles effortlessly. Timely delivery, well-packaged books – highly recommended satisfaction!.", AppUserId = "122ee49a-1c09-45ba-a6a5-4e94b3be7c85" },
                new Testimonial { Id = 3, Review = "Exceeded expectations, Pustok website. Robust search functionality, find what I wanted easily. Seamless checkout process, orders arrive promptly. Attention to detail, quality service keeps me coming back for more literary treasures.", AppUserId = "4e8b3ae2-4358-4d32-8fdf-d9a95df929e7" },
                new Testimonial { Id = 4, Review = "Can't say enough good things about Pustok! Vast array of genres, inclusion of hard-to-find titles. Aesthetically pleasing and highly functional design. Orders accurate, well-packaged, delivered on time – a gem in online book retail!", AppUserId = "8dce53a3-4394-46c3-8ebd-dbb06801e22e" },
                new Testimonial { Id = 5, Review = " hard-to-find titles. Aesthetically pleasing and highly functional design. Orders accurate, well-packaged, delivered on time – a gem in online book retail!", AppUserId = "8dce53a3-4394-46c3-8ebd-dbb06801e22e" },
                 new Testimonial { Id = 6, Review = "Can't say enough good things aboard-to-find e book retail!", AppUserId = "8dce53a3-4394-46c3-8ebd-dbb06801e22e" }


                );

            modelBuilder.Entity<Tag>().HasData(
                 new Tag { Id = 1, Name = "Fiction" },
                 new Tag { Id = 2, Name = "Non-Fiction" },
                    new Tag { Id = 3, Name = "Mystery" },
                 new Tag { Id = 4, Name = "History" },
                     new Tag { Id = 5, Name = "Fantasy" },
                 new Tag { Id = 6, Name = "Science Fiction" },
                  new Tag { Id = 7, Name = "Biography" },
                  new Tag { Id = 8, Name = "Self-Help" }
   );

            modelBuilder.Entity<BlogAuthor>().HasData(
                 new BlogAuthor { Id = 1, FullName = "Alice Johnson" },
                  new BlogAuthor { Id = 2, FullName = "Daniel Smith" },
                  new BlogAuthor { Id = 3, FullName = "Emily Davis" },
                  new BlogAuthor { Id = 4, FullName = "Michael Anderson" },
                   new BlogAuthor { Id = 5, FullName = "Olivia Brown" },
                  new BlogAuthor { Id = 6, FullName = "William Taylor" },
                      new BlogAuthor { Id = 7, FullName = "Sophia White" },
                  new BlogAuthor { Id = 8, FullName = "James Miller" },
                  new BlogAuthor { Id = 9, FullName = "Ava Wilson" },
                  new BlogAuthor { Id = 10, FullName = "Ethan Moore" }
);

            modelBuilder.Entity<Blog>().HasData(
                   new Blog
                   {
                       Id = 1,
                       Title = "The Literary Odyssey: Navigating Worlds of Wonder",
                       Description = @"Embark on an extraordinary literary odyssey that transcends the boundaries of time and space. Join us as we delve deep into the profound realms of storytelling, where the power of words transforms into mesmerizing tales of wonder and introspection. From classic masterpieces to contemporary gems, this blog is a celebration of the magic that books bring into our lives, inviting readers to navigate worlds of boundless imagination and endless discovery.

            The journey begins with the exploration of timeless classics that have stood the test of time, serving as pillars of literary achievement. Dive into the intricacies of character development, thematic richness, and the enduring relevance of stories that have captured the hearts of generations. Discover the nuances of narrative techniques and the artistry behind crafting immersive worlds that leave a lasting impact on the literary landscape.

            As we traverse through the literary cosmos, we'll unravel the threads of storytelling that connect cultures, generations, and the shared human experience. Each blog post is an invitation to explore the intersections of literature and life, where stories become a mirror reflecting the diversity and complexity of the human condition.

            Join us on this literary odyssey where words become vessels of imagination, emotion, and insight. Whether you're a seasoned bibliophile or a newcomer to the world of literature, there's something extraordinary waiting to be discovered in every chapter. Let the odyssey begin, and may the pages of your literary journey be filled with wonder, inspiration, and the joy of discovering the limitless possibilities of the written word.",
                       BlogAuthorId = 1,
                       CreatedDate = new DateTime(2023, 1, 15)
                   },
                    new Blog
                    {
                        Id = 2,
                        Title = "Whispers of the Imagination: Unraveling Mysteries Within Words",
                        Description = @"In the quiet corners of the imagination, stories come to life like whispers in the wind. Join us on a profound journey through the whispers of the imagination, where words weave tales of wonder, reflection, and captivating narratives. Explore the profound impact of books on our minds and the limitless realms they unveil, unraveling mysteries within each carefully chosen word.

            This blog is an invitation to engage with the profound artistry of storytelling, where the echoes of imagination resonate through the ages. Immerse yourself in the exploration of literary techniques that give life to characters, evoke emotions, and transport readers to faraway lands. From character-driven sagas to plot-twisting mysteries, every genre becomes a gateway to new dimensions of understanding and appreciation.

            Whispers of the Imagination seeks to unravel the layers of meaning embedded in the written word. It's not just about reading; it's about experiencing the magic of literature in its purest form. Join us in this exploration of literary craftsmanship, where every sentence is a brushstroke on the canvas of the reader's mind, creating vivid images and lasting impressions.

            Through discussions on symbolism, narrative structure, and the evolving landscape of literature, this blog aims to deepen the connection between readers and the stories that shape our collective imagination. Let the whispers of the imagination guide you through the enchanting world of literature, where each book is a doorway to discovery.",
                        BlogAuthorId = 2,
                        CreatedDate = new DateTime(2023, 1, 20)
                    },
    new Blog
    {
        Id = 3,
        Title = "Savoring the Pages of History: A Literary Feast of the Past",
        Description = @"Delve into the pages of history and savor the rich narratives that have shaped civilizations across time. This blog is a literary feast of the past, where every story becomes a portal to a bygone era. From ancient chronicles to modern historical epics, we invite you to discover the power of storytelling in preserving and transmitting the essence of our shared history.

            Savoring the Pages of History is a journey through time, exploring the vivid tapestry of human experiences, triumphs, and challenges. Each blog post unfolds like a chapter in a grand historical novel, shedding light on events, personalities, and cultural shifts that have left an indelible mark on the world.

            Join us in savoring the flavors of history, where the narrative becomes a banquet of knowledge and insight. From the rise and fall of empires to the untold stories of everyday heroes, this blog celebrates the diversity of historical literature. Engage with the complexities of historical interpretation, the art of storytelling, and the ongoing dialogue between the past and the present.

            As we navigate the pages of history, let the stories resonate with you, providing not only a glimpse into the past but also a deeper understanding of the present. Savoring the Pages of History is an exploration of the written word as a time machine, inviting readers to partake in a literary feast that transcends the boundaries of time and enriches our understanding of the world.",
        BlogAuthorId = 3,
        CreatedDate = new DateTime(2023, 4, 10)
    },
    new Blog
    {
        Id = 4,
        Title = "Unveiling the Secrets of Mystery: Journey into the Unknown",
        Description = @"Step into the shadowy realms of mystery as we unveil secrets, solve puzzles, and traverse the suspenseful landscapes of thrilling narratives. This blog is a journey into the unknown, where every twist and turn keeps readers on the edge of their seats. Join us in exploring the art of mystery writing and the timeless appeal of stories that captivate the mind, leaving a trail of intrigue and excitement in their wake.

            Unveiling the Secrets of Mystery delves into the psychology of suspense, the intricacies of plot construction, and the art of crafting memorable characters in the mystery genre. From classic whodunits to psychological thrillers, every subgenre becomes a gateway to understanding the various facets of mystery literature.

            Engage with discussions on detective fiction, crime thrillers, and the evolving nature of mystery narratives in contemporary literature. The blog seeks to unravel the secrets behind creating a compelling mystery, inviting readers to appreciate the craftsmanship of authors who keep them guessing until the final page.

            Let the journey into the unknown begin, where every shadow conceals a clue, and every revelation opens new possibilities. Unveiling the Secrets of Mystery is not just a blog; it's an exploration of the enigmatic and a celebration of the enduring allure of mystery in the world of literature.",
        BlogAuthorId = 4,
        CreatedDate = new DateTime(2023, 5, 5)
    },
    new Blog
    {
        Id = 5,
        Title = "Journeying Through Fantasy Realms: Where Dreams Take Flight",
        Description = @"Embark on an enchanting journey through fantastical realms where dragons soar, wizards cast spells, and heroes rise. This blog is a magical portal to worlds where dreams take flight, and the boundaries of reality are stretched to their limits. Explore the wonders of fantasy literature, where imagination knows no bounds, and epic adventures unfold with every turn of the page.

            Journeying Through Fantasy Realms is an invitation to explore the diverse landscapes of fantasy fiction, from high fantasy epics to urban fantasy adventures. Immerse yourself in discussions on world-building, mythical creatures, and the timeless themes that define the fantasy genre. Whether you're a seasoned fantasy enthusiast or a newcomer to the realms of magic and wonder, there's something captivating waiting to be discovered.

            Engage with explorations of legendary quests, magical systems, and the enduring appeal of fantastical storytelling. The blog seeks to unravel the threads that connect fantasy literature with our deepest desires for adventure, heroism, and the extraordinary. Join us in this journey where every page turns into a gateway to realms where dreams take flight, and the impossible becomes a reality in the hands of visionary authors.

            Let the magic of fantasy unfold before you, as we embark on a journey through realms where the boundaries between reality and imagination blur, and the fantastical becomes an integral part of the literary landscape.",
        BlogAuthorId = 5,
        CreatedDate = new DateTime(2023, 5, 15)
    },
    new Blog
    {
        Id = 6,
        Title = "Love and Romance in Written Words: A Symphony of Hearts",
        Description = @"Explore the nuanced landscapes of love and romance as portrayed through the written word. This blog is a celebration of the exquisite artistry found in tales of love and romance, where emotions unfold like a symphony of hearts. From timeless classics to contemporary tales, join us in a journey that delves into the complexities of human relationships, passion, and the enduring allure of stories that resonate with the deepest corners of the heart.

            Love and Romance in Written Words seeks to unravel the intricacies of romantic literature, exploring the varying shades of love, heartbreak, and the transformative power of emotional connection. Engage with discussions on romantic archetypes, narrative tropes, and the evolving representation of love in literature across different cultures and time periods.

            This blog is not merely about exploring love stories; it's an invitation to dissect the anatomy of romantic narratives, examining the elements that make them timeless and universally relatable. Join us in the exploration of love as a literary theme, where every novel becomes a unique note in the symphony of hearts that resonates across the pages of written words.

            Whether you're a hopeless romantic or a curious reader intrigued by the complexities of human emotion, Love and Romance in Written Words promises a journey through literary landscapes where love unfolds in its many forms, leaving an indelible mark on the reader's heart.",
        BlogAuthorId = 6,
        CreatedDate = new DateTime(2021, 6, 25)
    },
    new Blog
    {
        Id = 7,
        Title = "Charting the Course of Science Fiction: Exploring Tomorrow's Frontiers",
        Description = @"Chart a course through the galaxies of science fiction literature. This blog is an invitation to explore tomorrow's frontiers, where futuristic worlds, advanced technologies, and thought-provoking speculations on the future of humanity come to life. Join us in unraveling the limitless possibilities that science fiction offers to the curious reader, charting a course through the cosmos of imagination and innovation.

            Charting the Course of Science Fiction delves into the ever-evolving landscape of sci-fi literature, from classic space operas to speculative visions of the future. Engage with discussions on the intersection of science, technology, and storytelling, as we navigate the ethical dilemmas, utopian visions, and dystopian nightmares that define the genre.

            The blog seeks to explore the influence of science fiction on societal perspectives, technological advancements, and the shaping of possible futures. Join us in contemplating the 'what if' scenarios, where authors envision worlds that challenge our understanding of reality and push the boundaries of human potential.

            Whether you're a seasoned science fiction enthusiast or a newcomer to the genre, Charting the Course of Science Fiction promises an exploration of literary frontiers that expand the mind and spark the imagination. Let the journey through the galaxies of science fiction literature begin, where every novel becomes a star in the vast constellation of speculative storytelling.",
        BlogAuthorId = 7,
        CreatedDate = new DateTime(2022, 7, 12)
    },
    new Blog
    {
        Id = 8,
        Title = "Literary Explorations in Non-Fiction: Illuminating Real-World Narratives",
        Description = @"Embark on intellectual voyages through the realms of non-fiction literature. This blog is a journey of illumination into real-world narratives that enlighten, challenge, and expand our understanding of the world. From thought-provoking essays to insightful biographies, we invite readers to delve into the vast landscape of non-fiction, where every page holds a treasure trove of knowledge waiting to be discovered.

            Literary Explorations in Non-Fiction delves into the diverse realms of factual storytelling, from historical accounts to contemporary analyses of global issues. Engage with discussions on the impact of non-fiction literature on society, the role of the author as a guide through complex subjects, and the ethical considerations inherent in documenting real-world events.

            The blog seeks to bridge the gap between the worlds of fiction and non-fiction, exploring the ways in which narrative techniques and storytelling conventions are employed to convey real-world truths. Join us in the exploration of literary explorations, where every non-fiction book becomes a window into the complexities, wonders, and challenges of the world we inhabit.

            Whether you're passionate about history, social issues, or scientific discoveries, Literary Explorations in Non-Fiction promises a curated journey through the vast expanse of non-fiction literature, where every book is a beacon of knowledge waiting to be discovered and shared.",
        BlogAuthorId = 8,
        CreatedDate = new DateTime(2020, 9, 8)
    },
      new Blog
      {
          Id = 9,
          Title = "The Art of Short Stories: Crafting Emotional Microcosms",
          Description = @"Celebrate the art of brevity and depth in the world of short stories. This blog is an exploration of the intricate craft of short-form fiction, where every word carries weight, and concise narratives unfold powerful emotions, vivid characters, and thought-provoking themes. Join us in appreciating the beauty of crafting emotional microcosms within the limited canvas of short stories, where the essence of storytelling is distilled into its purest form.

            The Art of Short Stories delves into the profound impact of brevity, exploring how concise narratives have the power to evoke deep emotions, spark contemplation, and leave a lasting imprint on the reader's imagination. Engage with discussions on the art of pacing, character development, and thematic resonance within the unique structure of short stories.

            This blog is not just an exploration of the short story as a literary form; it's an invitation to discover the diverse voices and styles that contribute to the richness of short-form fiction. Join us in celebrating the storytellers who masterfully navigate the delicate balance between conciseness and depth, creating emotional landscapes that linger in the minds of readers long after the final sentence.

            Whether you're a seasoned admirer of short stories or a newcomer curious about the potential within brevity, The Art of Short Stories promises a curated journey through the captivating world of succinct narratives, where every story is a testament to the enduring power of concise and emotionally resonant storytelling.",
          BlogAuthorId = 9,
          CreatedDate = new DateTime(2021, 9, 2)
      },

     new Blog
     {
         Id = 10,
         Title = "Literary Reflections on Self-Help: Navigating the Path to Personal Growth",
         Description = @"Navigate the landscapes of self-discovery and personal growth through the lens of literature. This blog offers reflective insights into the wisdom embedded in self-help books, exploring the ways in which written words can guide, inspire, and empower individuals on their journey towards a fulfilling life.

            In a world filled with challenges and complexities, the pursuit of personal development becomes a transformative journey. Each blog post is a thoughtful exploration of self-help literature, delving into the profound teachings and transformative narratives that have the potential to shape perspectives and ignite positive change.

            Discover the power of mindset shifts, goal setting, and resilience through the lens of renowned self-help authors. From timeless classics to contemporary guides, this blog aims to curate a collection of insights that resonate with readers seeking inspiration, motivation, and practical strategies for personal and professional growth.

            Through literary reflections, we will explore the intersection of literature and self-help, examining how the written word becomes a guiding light in moments of uncertainty and a source of strength during life's transitions. Whether you're embarking on a quest for mindfulness, resilience, or purpose, join us on this exploration of self-help literature as we navigate the path to personal growth together.

            The journey unfolds with each turn of the page, offering readers a roadmap to self-discovery, empowerment, and a renewed sense of purpose. May these literary reflections serve as companions on your quest for a more meaningful and fulfilling life.",
         BlogAuthorId = 10,
         CreatedDate = new DateTime(2022, 10, 18)
     }
                   );



            modelBuilder.Entity<BlogImage>().HasData(

                new BlogImage { Id = 1, Image = "blog-grid-1.webp", BlogId = 1, IsMain = true, SoftDeleted = false },
                new BlogImage { Id = 2, Image = "blog-grid-2.webp", BlogId = 1, IsMain = false, SoftDeleted = false },

                new BlogImage { Id = 3, Image = "blog-grid-2.webp", BlogId = 2, IsMain = true, SoftDeleted = false },
                new BlogImage { Id = 4, Image = "blog-grid-3.webp", BlogId = 2, IsMain = false, SoftDeleted = false },

                new BlogImage { Id = 5, Image = "blog-grid-3.webp", BlogId = 3, IsMain = true, SoftDeleted = false },
                new BlogImage { Id = 6, Image = "blog-grid-4.webp", BlogId = 3, IsMain = false, SoftDeleted = false },

                new BlogImage { Id = 7, Image = "blog-grid-4.webp", BlogId = 4, IsMain = true, SoftDeleted = false },
                new BlogImage { Id = 8, Image = "blog-grid-1.webp", BlogId = 4, IsMain = false, SoftDeleted = false },

                new BlogImage { Id = 9, Image = "blog-grid-2.webp", BlogId = 5, IsMain = true, SoftDeleted = false },
                new BlogImage { Id = 10, Image = "blog-grid-4.webp", BlogId = 5, IsMain = false, SoftDeleted = false },

                new BlogImage { Id = 11, Image = "blog-grid-1.webp", BlogId = 6, IsMain = true, SoftDeleted = false },
                new BlogImage { Id = 12, Image = "blog-grid-3.webp", BlogId = 6, IsMain = false, SoftDeleted = false },

                new BlogImage { Id = 13, Image = "blog-grid-3.webp", BlogId = 7, IsMain = true, SoftDeleted = false },
                new BlogImage { Id = 14, Image = "blog-grid-4.webp", BlogId = 7, IsMain = false, SoftDeleted = false },

                new BlogImage { Id = 15, Image = "blog-grid-4.webp", BlogId = 8, IsMain = true, SoftDeleted = false },
                new BlogImage { Id = 16, Image = "blog-grid-1.webp", BlogId = 8, IsMain = false, SoftDeleted = false },

                new BlogImage { Id = 17, Image = "blog-grid-2.webp", BlogId = 9, IsMain = true, SoftDeleted = false },
                new BlogImage { Id = 18, Image = "blog-grid-4.webp", BlogId = 9, IsMain = false, SoftDeleted = false },

                new BlogImage { Id = 19, Image = "blog-grid-1.webp", BlogId = 10, IsMain = true, SoftDeleted = false },
                new BlogImage { Id = 20, Image = "blog-grid-3.webp", BlogId = 10, IsMain = false, SoftDeleted = false }
                );



            modelBuilder.Entity<BlogTag>().HasData(
    new BlogTag { Id = 1, BlogId = 1, TagId = 1 },
    new BlogTag { Id = 2, BlogId = 1, TagId = 5 },
    new BlogTag { Id = 3, BlogId = 1, TagId = 8 },
    new BlogTag { Id = 4, BlogId = 1, TagId = 4 },
    new BlogTag { Id = 5, BlogId = 2, TagId = 1 },
    new BlogTag { Id = 6, BlogId = 2, TagId = 7 },
    new BlogTag { Id = 7, BlogId = 2, TagId = 3 },
    new BlogTag { Id = 8, BlogId = 2, TagId = 6 },
    new BlogTag { Id = 9, BlogId = 3, TagId = 1 },
    new BlogTag { Id = 10, BlogId = 3, TagId = 2 },
    new BlogTag { Id = 11, BlogId = 3, TagId = 5 },
    new BlogTag { Id = 12, BlogId = 3, TagId = 3 },
    new BlogTag { Id = 13, BlogId = 4, TagId = 1 },
    new BlogTag { Id = 14, BlogId = 4, TagId = 5 },
    new BlogTag { Id = 15, BlogId = 4, TagId = 6 },
    new BlogTag { Id = 16, BlogId = 5, TagId = 4 },
    new BlogTag { Id = 17, BlogId = 5, TagId = 1 },
    new BlogTag { Id = 18, BlogId = 5, TagId = 4 },
    new BlogTag { Id = 19, BlogId = 6, TagId = 3 },
    new BlogTag { Id = 20, BlogId = 6, TagId = 6 },
    new BlogTag { Id = 21, BlogId = 6, TagId = 1 },
    new BlogTag { Id = 22, BlogId = 7, TagId = 7 },
    new BlogTag { Id = 23, BlogId = 7, TagId = 5 },
    new BlogTag { Id = 24, BlogId = 7, TagId = 3 },
    new BlogTag { Id = 25, BlogId = 8, TagId = 6 },
    new BlogTag { Id = 26, BlogId = 8, TagId = 8 },
    new BlogTag { Id = 27, BlogId = 8, TagId = 2 },
    new BlogTag { Id = 28, BlogId = 8, TagId = 5 },

    new BlogTag { Id = 29, BlogId = 9, TagId = 1 },
    new BlogTag { Id = 30, BlogId = 9, TagId = 7 },
    new BlogTag { Id = 31, BlogId = 9, TagId = 2 },
    new BlogTag { Id = 32, BlogId = 9, TagId = 4 },

     new BlogTag { Id = 33, BlogId = 10, TagId = 3 },
    new BlogTag { Id = 34, BlogId = 10, TagId = 6 },
    new BlogTag { Id = 35, BlogId = 10, TagId = 5 },
    new BlogTag { Id = 36, BlogId = 10, TagId = 7 }

    );

            modelBuilder.Entity<BlogComment>().HasData(
                
                new BlogComment { Id=1,Message= "The book recommendations on this blog are like a treasure map for bibliophiles! 🗺️📚 Each review is a journey into a new literary world. I recently picked up a suggested novel, and it completely captivated me. Thanks for being my guide in the vast realm of books!", BlogId=1,AppUserId= "0efd01de-4eec-45ff-9de4-f03f9abdf104" },
                new BlogComment { Id = 2, Message = "This blog is my go-to source for discovering hidden gems in the book world. The recent post on Naoki Urasawa's latest work was spot-on! The storytelling is phenomenal, and the blog's insights added a new layer to my reading experience. Can't wait for the next recommendation!", BlogId = 2, AppUserId = "122ee49a-1c09-45ba-a6a5-4e94b3be7c85" },
                new BlogComment { Id = 3, Message = "Kudos to the blog for introducing me to fantastic books I never thought I'd enjoy. The thoughtful reviews make it easy to step out of my comfort zone. I picked up one of the recommended titles, and it turned out to be a pleasant surprise. Keep broadening our literary horizons!", BlogId = 3, AppUserId = "4e8b3ae2-4358-4d32-8fdf-d9a95df929e7" },
                new BlogComment { Id = 4, Message = "I appreciate the diverse range of books covered on this blog. The variety in genres and themes keeps my reading list exciting and unpredictable. The recent review on No Longer Human was enlightening. It's evident that the blogger has a genuine passion for literature. Bravo!", BlogId = 4, AppUserId = "8dce53a3-4394-46c3-8ebd-dbb06801e22e" },
                new BlogComment { Id = 5, Message = "I've been following this blog for months, and it never disappoints. The reviews are like a sneak peek into the soul of each book. The latest post on Jack London's novel left me eager to explore more of their work. Thanks for consistently providing such enriching content!", BlogId = 5, AppUserId = "0efd01de-4eec-45ff-9de4-f03f9abdf104" },
                new BlogComment { Id = 6, Message = "The blog's reviews are like a beacon guiding me to the most intriguing plots and characters. I enjoyed the recent discussion on Romance. The analysis was thought-provoking and added a new layer of appreciation for the books in that category. An intellectual oasis for bookworms!", BlogId = 6, AppUserId = "122ee49a-1c09-45ba-a6a5-4e94b3be7c85" },
                new BlogComment { Id = 7, Message = "This blog is a haven for those seeking literary escapades. The recent post on Fourth Wing resonated with me deeply. The emotional nuances explored in the review mirrored my own experience with the book. It's wonderful to find a community that shares the love for storytelling.", BlogId = 7, AppUserId = "4e8b3ae2-4358-4d32-8fdf-d9a95df929e7" },
                new BlogComment { Id = 8, Message = "The book recommendations here are like a curated collection of literary wonders. I recently picked up a novel highlighted in a post, and it became an instant favorite. Thank you for helping me discover gems I might have overlooked otherwise. Looking forward to the next revelation!", BlogId = 8, AppUserId = "8dce53a3-4394-46c3-8ebd-dbb06801e22e" },
                new BlogComment { Id = 9, Message = "This blog has become my literary compass. The reviews not only provide insights into the books but also ignite interesting discussions in the comments section. It's a community where book lovers unite. The recent post on detective sparked engaging conversations. Cheers to a blog that fosters a love for reading!", BlogId = 9, AppUserId = "0efd01de-4eec-45ff-9de4-f03f9abdf104" },
                new BlogComment { Id = 10, Message = "I'm constantly impressed by the range of genres covered on this blog. The recent spotlight on Madeline MIller's works was a delightful surprise. I've now added their entire bibliography to my to-be-read list. The blog consistently delivers exciting discoveries for avid readers. Much appreciated!", BlogId = 10, AppUserId = "4e8b3ae2-4358-4d32-8fdf-d9a95df929e7" }


                );



            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1,Name="Biographies"},
                 new Category { Id = 2, Name = "Business & Money" },
                  new Category { Id = 3, Name = "Children's Books" },
                   new Category { Id = 4, Name = "Comics" },
                    new Category { Id = 5, Name = "Cookbooks" },
                     new Category { Id = 6, Name = "Education" },
                      new Category { Id = 7, Name = "Arts & Photography" }
                );

            modelBuilder.Entity<Author>().HasData(
             new Author { Id = 1, FullName = "Jane Austen" },
             new Author { Id = 2, FullName = "Charles Dickens" },
             new Author { Id = 3, FullName = "Agatha Christie" },
             new Author { Id = 4, FullName = "F. Scott Fitzgerald" },
             new Author { Id = 5, FullName = "J.K. Rowling" },
             new Author { Id = 6, FullName = "Gabriel Garcia Marquez" },
             new Author { Id = 7, FullName = "Harper Lee" },
             new Author { Id = 8, FullName = "George Orwell" },
             new Author { Id = 9, FullName = "Ernest Hemingway" },
             new Author { Id = 10, FullName = "Toni Morrison" },
             new Author { Id = 11, FullName = "Mark Twain" },
             new Author { Id = 12, FullName = "J.R.R. Tolkien" },
             new Author { Id = 13, FullName = "Virginia Woolf" },
             new Author { Id = 14, FullName = "Leo Tolstoy" },
             new Author { Id = 15, FullName = "Emily Brontë" }
         );

            modelBuilder.Entity<Discount>().HasData(
                  new Discount { Id = 1, Name = "Spring Sale", Percent = 15 },
                  new Discount { Id = 2, Name = "Back-to-School", Percent = 10 },
                  new Discount { Id = 3, Name = "Holiday Special", Percent = 25 },
                  new Discount { Id = 4, Name = "Summer Reading", Percent = 20 },
                  new Discount { Id = 5, Name = "New Year's Clearance", Percent = 30 },
                  new Discount { Id = 6, Name = "Weekend Flash Sale", Percent = 15 },
                  new Discount { Id = 7, Name = "Member Exclusive", Percent = 10 },
                  new Discount { Id = 8, Name = "Book Club Discount", Percent = 20 },
                  new Discount { Id = 9, Name = "Black Friday", Percent = 40 },
                  new Discount { Id = 10, Name = "Fall Frenzy", Percent = 15 }
                 );

            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     Name = "The Enchanting Tale",
                     Description = "In the magical realm of Eldoria, where dragons soar and wizards weave spells, embark on a mesmerizing journey with 'The Enchanting Tale.' This epic fantasy novel, written by the acclaimed author Jane Austen, unfolds a captivating narrative of courage, destiny, and enchantment. Join our young protagonist as they navigate through mystical landscapes, encountering mythical creatures and facing formidable challenges.",
                     Price = 55,
                     Rate = 3,
                     SaleCount = 5,
                     StockCount = 10,
                     Sku = "ENCTLE123",
                     AuthorId = 1,  
                     DiscountId = 1,
                     CategoryId = 1,
                     CreatedDate = new DateTime(2022, 10, 18)
                 },
                   new Product
                   {
                       Id = 2,
                       Name = "Whispers of the Cosmos",
                       Description = "Delve into the cosmic mysteries with 'Whispers of the Cosmos,' a thought-provoking science fiction masterpiece. Written by the visionary J.R.R. Tolkien, this interstellar journey takes readers beyond the limits of space and time. Join a diverse cast of characters as they unravel the secrets of the universe, encountering extraterrestrial civilizations and confronting the profound questions that echo through the cosmos.",
                       Price = 43,
                       Rate = 4,
                       SaleCount = 8,
                       StockCount = 15,
                       Sku = "COSMOS456",
                       AuthorId = 2,  
                       DiscountId = 3,
                       CategoryId = 2,
                       CreatedDate = new DateTime(2023, 11, 19)
                   },

                   new Product
                   {
                       Id = 3,
                       Name = "Gourmet Adventures",
                       Description = "Embark on a culinary journey with 'Gourmet Adventures,' a delightful cookbook filled with delectable recipes from renowned chefs worldwide. From exotic appetizers to mouth-watering desserts, savor the flavors of diverse cuisines and elevate your culinary skills.",
                       Price = 30,
                       Rate = 5,
                       SaleCount = 12,
                       StockCount = 20,
                       Sku = "GOURMET789",
                       AuthorId = 3,  
                       DiscountId = 2,
                       CategoryId = 5,
                       CreatedDate = new DateTime(2021, 09, 10)
                   },
                    new Product
                    {
                        Id = 4,
                        Name = "Historical Chronicles",
                        Description = "Immerse yourself in the past with 'Historical Chronicles,' a collection of meticulously researched historical accounts. Written by F. Scott Fitzgerald, these narratives bring to life the events and characters that shaped our world.",
                        Price = 46,
                        Rate = 3,
                        SaleCount = 7,
                        StockCount = 18,
                        Sku = "HISTCHRON101",
                        AuthorId = 4,  
                        DiscountId = 4,
                        CategoryId = 6,
                        CreatedDate = new DateTime(2023, 11, 08)
                    },
                    new Product
                    {
                        Id = 5,
                        Name = "Magical Realms",
                        Description = "Step into 'Magical Realms,' a enchanting compilation of short stories that blur the lines between reality and fantasy. Crafted by J.K. Rowling, each tale unfolds a world where magic and wonder coexist with the ordinary.",
                        Price = 60,
                        Rate = 5,
                        SaleCount = 10,
                        StockCount = 15,
                        Sku = "MAGIREALM222",
                        AuthorId = 5,  
                        DiscountId = 1,
                        CategoryId = 3,
                        CreatedDate = new DateTime(2024, 01, 15)
                    },
                    new Product
                    {
                        Id = 6,
                        Name = "Mindful Living",
                        Description = "Discover the path to mindful living with 'Mindful Living,' a guide to wellness and self-discovery. In this insightful book by Gabriel Garcia Marquez, learn practical techniques and wisdom to cultivate a balanced and meaningful life.",
                        Price = 50,
                        Rate = 3,
                        SaleCount = 15,
                        StockCount = 25,
                        Sku = "MINDLIVE333",
                        AuthorId = 6,  
                        DiscountId = 3,
                        CategoryId = 7,
                        CreatedDate = new DateTime(2023, 11, 30)
                    },

                        new Product
                        {
                            Id = 7,
                            Name = "Harmony of Colors",
                            Description = "Explore the world of art with 'Harmony of Colors,' a vibrant collection of paintings and photographs. Authored by Harper Lee, this book celebrates the beauty of visual expression and the emotional resonance of color.",
                            Price = 55,
                            Rate = 4,
                            SaleCount = 8,
                            StockCount = 20,
                            Sku = "HARMCOLOR444",
                            AuthorId = 7,  
                            DiscountId = 5,
                            CategoryId = 4,
                            CreatedDate = new DateTime(2023, 06, 08)
                        },

                         new Product
                         {
                             Id = 8,
                             Name = "Animal Kingdom",
                             Description = "Dive into the wonders of the 'Animal Kingdom,' a captivating exploration of wildlife and ecosystems. Authored by George Orwell, this book showcases the beauty and diversity of the natural world.",
                             Price = 30,
                             Rate = 2,
                             SaleCount = 10,
                             StockCount = 15,
                             Sku = "ANIMALKING555",
                             AuthorId = 8,  
                             DiscountId = 2,
                             CategoryId = 6,
                             CreatedDate = new DateTime(2023, 11, 12)
                         },

                          new Product
                          {
                              Id = 9,
                              Name = "Culinary Adventures",
                              Description = "Embark on 'Culinary Adventures,' a gastronomic journey through diverse cuisines and culinary traditions. Authored by Ernest Hemingway, this cookbook brings the joy of cooking to enthusiasts of all skill levels.",
                              Price = 40,
                              Rate = 5,
                              SaleCount = 12,
                              StockCount = 18,
                              Sku = "CULADVENT666",
                              AuthorId = 9,  
                              DiscountId = 4,
                              CategoryId = 5,
                              CreatedDate = new DateTime(2022, 12, 25)
                          },

                           new Product
                           {
                               Id = 10,
                               Name = "Exploring the Cosmos",
                               Description = "Embark on a cosmic adventure with 'Exploring the Cosmos,' a journey into the mysteries of the universe. Authored by Toni Morrison, this science fiction odyssey takes readers on a mind-bending exploration of space and time.",
                               Price = 60,
                               Rate = 5,
                               SaleCount = 15,
                               StockCount = 22,
                               Sku = "COSMOEXP777",
                               AuthorId = 10,  
                               DiscountId = 1,
                               CategoryId = 2,
                               CreatedDate = new DateTime(2023, 07, 18)
                           },
    new Product
    {
        Id = 11,
        Name = "Surreal Dreams",
        Description = "Enter the realm of 'Surreal Dreams,' a collection of imaginative short stories that defy conventional reality. Authored by Virginia Woolf, each tale invites readers to explore the boundaries of perception and dreamlike narratives.",
        Price = 46,
        Rate = 4,
        SaleCount = 11,
        StockCount = 16,
        Sku = "SURREALDREAM888",
        AuthorId = 11, 
        DiscountId = 3,
        CategoryId = 1,
        CreatedDate = new DateTime(2023, 08, 18)
    },
    new Product
    {
        Id = 12,
        Name = "The Art of Serenity",
        Description = "Discover 'The Art of Serenity,' a guide to mindfulness and inner peace by Leo Tolstoy. This inspirational book offers timeless wisdom and practical insights to navigate the complexities of modern life.",
        Price = 35,
        Rate = 3,
        SaleCount = 13,
        StockCount = 19,
        Sku = "SERENITY999",
        AuthorId = 12,  
        DiscountId = 2,
        CategoryId = 7,
        CreatedDate = new DateTime(2022, 09, 18)
    },
    new Product
    {
        Id = 13,
        Name = "Epic Adventures",
        Description = "Embark on 'Epic Adventures,' a thrilling compilation of action-packed stories from master storyteller Mark Twain. This riveting collection takes readers on a journey through daring escapades, uncharted territories, and the triumph of the human spirit.",
        Price = 40,
        Rate =3,
        SaleCount = 9,
        StockCount = 14,
        Sku = "EPICADV1010",
        AuthorId = 13,  
        DiscountId = 4,
        CategoryId = 3,
        CreatedDate = new DateTime(2023, 10, 18)
    },
    new Product
    {
        Id = 14,
        Name = "Poetic Musings",
        Description = "Dive into the enchanting world of 'Poetic Musings,' a lyrical journey through the verses of Langston Hughes. This collection of poetry captures the essence of life, love, and the beauty found in the simple moments of existence.",
        Price = 30,
        Rate = 4,
        SaleCount = 10,
        StockCount = 17,
        Sku = "POETICMUSE1111",
        AuthorId = 14,  
        DiscountId = 5,
        CategoryId = 5,
        CreatedDate = new DateTime(2022, 12, 18)
    },

    new Product
    {
        Id = 15,
        Name = "Thrilling Escapes",
        Description = "Immerse yourself in 'Thrilling Escapes,' a captivating collection of suspenseful tales from the brilliant mind of H.G. Wells. This anthology explores the boundaries of imagination and keeps readers on the edge of their seats.",
        Price = 45,
        Rate = 3,
        SaleCount = 14,
        StockCount = 21,
        Sku = "THRILLESCAPE1212",
        AuthorId = 15,  
        DiscountId = 1,
        CategoryId = 3,
        CreatedDate = new DateTime(2023, 12, 29)
    }
   );

            modelBuilder.Entity<ProductImage>().HasData(
          new ProductImage { Id = 1, Image = "product-1.webp", IsMain = true, ProductId = 1, SoftDeleted = false },
          new ProductImage { Id = 2, Image = "product-2.webp", IsMain = false, ProductId = 1, SoftDeleted = false },

           new ProductImage { Id = 3, Image = "product-2.webp", IsMain = true, ProductId = 2, SoftDeleted = false },
          new ProductImage { Id = 4, Image = "product-3.webp", IsMain = false, ProductId = 2, SoftDeleted = false },

          new ProductImage { Id = 5, Image = "product-3.webp", IsMain = true, ProductId = 3, SoftDeleted = false },
          new ProductImage { Id = 6, Image = "product-4.webp", IsMain = false, ProductId = 3, SoftDeleted = false },

           new ProductImage { Id = 7, Image = "product-4.webp", IsMain = true, ProductId = 4, SoftDeleted = false },
          new ProductImage { Id = 8, Image = "product-5.webp", IsMain = false, ProductId = 4, SoftDeleted = false },

           new ProductImage { Id = 9, Image = "product-5.webp", IsMain = true, ProductId = 5, SoftDeleted = false },
          new ProductImage { Id = 10, Image = "product-6.webp", IsMain = false, ProductId = 5, SoftDeleted = false },

           new ProductImage { Id = 11, Image = "product-6.webp", IsMain = true, ProductId = 6, SoftDeleted = false },
          new ProductImage { Id = 12, Image = "product-7.webp", IsMain = false, ProductId = 6, SoftDeleted = false },

             new ProductImage { Id = 13, Image = "product-7.webp", IsMain = true, ProductId = 7, SoftDeleted = false },
          new ProductImage { Id = 14, Image = "product-8.webp", IsMain = false, ProductId = 7, SoftDeleted = false },

           new ProductImage { Id = 15, Image = "product-8.webp", IsMain = true, ProductId = 8, SoftDeleted = false },
          new ProductImage { Id = 16, Image = "product-9.webp", IsMain = false, ProductId = 8, SoftDeleted = false },

          new ProductImage { Id = 17, Image = "product-9.webp", IsMain = true, ProductId = 9, SoftDeleted = false },
          new ProductImage { Id = 18, Image = "product-10.webp", IsMain = false, ProductId = 9, SoftDeleted = false },

           new ProductImage { Id = 19, Image = "product-10.webp", IsMain = true, ProductId = 10, SoftDeleted = false },
          new ProductImage { Id = 20, Image = "product-11.webp", IsMain = false, ProductId = 10, SoftDeleted = false },

           new ProductImage { Id = 21, Image = "product-11.webp", IsMain = true, ProductId = 11, SoftDeleted = false },
          new ProductImage { Id = 22, Image = "product-12.webp", IsMain = false, ProductId = 11, SoftDeleted = false },

           new ProductImage { Id = 23, Image = "product-12.webp", IsMain = true, ProductId = 12, SoftDeleted = false },
          new ProductImage { Id = 24, Image = "product-1.webp", IsMain = false, ProductId = 12, SoftDeleted = false },

                 new ProductImage { Id = 25, Image = "product-3.webp", IsMain = true, ProductId = 13, SoftDeleted = false },
          new ProductImage { Id = 26, Image = "product-5.webp", IsMain = false, ProductId = 13, SoftDeleted = false },

           new ProductImage { Id = 27, Image = "product-7.webp", IsMain = true, ProductId = 14, SoftDeleted = false },
          new ProductImage { Id = 28, Image = "product-4.webp", IsMain = false, ProductId = 14, SoftDeleted = false },

           new ProductImage { Id = 29, Image = "product-6.webp", IsMain = true, ProductId = 15, SoftDeleted = false },
          new ProductImage { Id = 30, Image = "product-4.webp", IsMain = false, ProductId = 15, SoftDeleted = false }
          );

            modelBuilder.Entity<ProductTag>().HasData(
      new ProductTag { Id = 1, ProductId = 1, TagId = 1 },
      new ProductTag { Id = 2, ProductId = 1, TagId = 5 },
      new ProductTag { Id = 3, ProductId = 1, TagId = 8 },
      new ProductTag { Id = 4, ProductId = 1, TagId = 4 },
      new ProductTag { Id = 5, ProductId = 2, TagId = 1 },
      new ProductTag { Id = 6, ProductId = 2, TagId = 7 },
      new ProductTag { Id = 7, ProductId = 2, TagId = 3 },
      new ProductTag { Id = 8, ProductId = 2, TagId = 6 },
      new ProductTag { Id = 9, ProductId = 3, TagId = 1 },
      new ProductTag { Id = 10, ProductId = 3, TagId = 2 },
      new ProductTag { Id = 11, ProductId = 3, TagId = 5 },
      new ProductTag { Id = 12, ProductId = 3, TagId = 3 },
      new ProductTag { Id = 13, ProductId = 4, TagId = 1 },
      new ProductTag { Id = 14, ProductId = 4, TagId = 5 },
      new ProductTag { Id = 15, ProductId = 4, TagId = 6 },
      new ProductTag { Id = 16, ProductId = 5, TagId = 4 },
      new ProductTag { Id = 17, ProductId = 5, TagId = 1 },
      new ProductTag { Id = 18, ProductId = 5, TagId = 4 },
      new ProductTag { Id = 19, ProductId = 6, TagId = 3 },
      new ProductTag { Id = 20, ProductId = 6, TagId = 6 },
      new ProductTag { Id = 21, ProductId = 6, TagId = 1 },
      new ProductTag { Id = 22, ProductId = 7, TagId = 7 },
      new ProductTag { Id = 23, ProductId = 7, TagId = 5 },
      new ProductTag { Id = 24, ProductId = 7, TagId = 3 },
      new ProductTag { Id = 25, ProductId = 8, TagId = 6 },
      new ProductTag { Id = 26, ProductId = 8, TagId = 8 },
      new ProductTag { Id = 27, ProductId = 8, TagId = 2 },
      new ProductTag { Id = 28, ProductId = 8, TagId = 5 },
      new ProductTag { Id = 29, ProductId = 9, TagId = 1 },
      new ProductTag { Id = 30, ProductId = 9, TagId = 7 },
      new ProductTag { Id = 31, ProductId = 9, TagId = 2 },
      new ProductTag { Id = 32, ProductId = 9, TagId = 4 },
      new ProductTag { Id = 33, ProductId = 10, TagId = 3 },
      new ProductTag { Id = 34, ProductId = 10, TagId = 6 },
      new ProductTag { Id = 35, ProductId = 10, TagId = 5 },
      new ProductTag { Id = 36, ProductId = 10, TagId = 7 },
      new ProductTag { Id = 37, ProductId = 11, TagId = 1 },
      new ProductTag { Id = 38, ProductId = 11, TagId = 3 },
      new ProductTag { Id = 39, ProductId = 11, TagId = 2 },
       new ProductTag { Id = 40, ProductId = 12, TagId = 3 },
      new ProductTag { Id = 41, ProductId = 12, TagId = 4 },
      new ProductTag { Id = 42, ProductId = 12, TagId = 8 },
        new ProductTag { Id = 43, ProductId = 13, TagId = 1 },
      new ProductTag { Id = 44, ProductId = 13, TagId = 3 },
      new ProductTag { Id = 45, ProductId = 13, TagId = 5 },
           new ProductTag { Id = 46, ProductId = 14, TagId = 2 },
      new ProductTag { Id = 47, ProductId = 14, TagId = 6 },
      new ProductTag { Id = 48, ProductId = 14, TagId = 8 },
           new ProductTag { Id = 49, ProductId = 15, TagId = 3 },
      new ProductTag { Id = 50, ProductId = 15, TagId = 5 },
      new ProductTag { Id = 51, ProductId = 15, TagId = 8 }
  );



            modelBuilder.Entity<ProductComment>().HasData(
    new ProductComment { Id = 1,Rate=3, Message = "The intricate plot and well-developed characters in this book kept me hooked from the first page. A must-read for anyone who loves a gripping story!", ProductId = 1, AppUserId = "0efd01de-4eec-45ff-9de4-f03f9abdf104" },
    new ProductComment { Id = 2, Rate = 2, Message = "I was pleasantly surprised by the unexpected twists and turns in this book. The author's storytelling style is captivating, making it a compelling read.", ProductId = 2, AppUserId = "122ee49a-1c09-45ba-a6a5-4e94b3be7c85" },
    new ProductComment { Id = 3, Rate = 5, Message = "The emotional depth and thought-provoking themes explored in this book left a lasting impact. I highly recommend it to fellow readers who appreciate profound storytelling.", ProductId = 3, AppUserId = "4e8b3ae2-4358-4d32-8fdf-d9a95df929e7" },
    new ProductComment { Id = 4, Rate = 4, Message = "An engaging and well-written book that offers a unique perspective on its subject matter. The author's creativity shines through, making it a standout addition to my reading list.", ProductId = 4, AppUserId = "8dce53a3-4394-46c3-8ebd-dbb06801e22e" },
    new ProductComment { Id = 5, Rate = 1, Message = "This book has become one of my all-time favorites. The rich narrative and memorable characters make it a must-read for book enthusiasts. I look forward to exploring more works by the same author.", ProductId = 5, AppUserId = "0efd01de-4eec-45ff-9de4-f03f9abdf104" },
    new ProductComment { Id = 6, Rate = 1, Message = "The author's ability to weave together various storylines in this book is truly commendable. It kept me engrossed until the very end, and I can't wait to delve into their other literary creations.", ProductId = 6, AppUserId = "122ee49a-1c09-45ba-a6a5-4e94b3be7c85" },
    new ProductComment { Id = 7, Rate = 2, Message = "A thought-provoking and well-researched book that explores complex themes with clarity. The author's writing style adds a layer of authenticity to the narrative, making it a standout work in its genre.", ProductId = 7, AppUserId = "4e8b3ae2-4358-4d32-8fdf-d9a95df929e7" },
    new ProductComment { Id = 8, Rate = 3, Message = "Kudos to the author for creating such a captivating story. This book is a testament to their storytelling prowess, and I eagerly await their future works.", ProductId = 8, AppUserId = "8dce53a3-4394-46c3-8ebd-dbb06801e22e" },
    new ProductComment { Id = 9, Rate = 4, Message = "The beautifully crafted prose and engaging narrative of this book make it a standout in contemporary literature. I recommend it to fellow readers who appreciate a well-told tale.", ProductId = 9, AppUserId = "0efd01de-4eec-45ff-9de4-f03f9abdf104" },
    new ProductComment { Id = 10, Rate =5, Message = "An enthralling read that seamlessly blends elements of mystery and suspense. This book kept me on the edge of my seat, and I'm eager to explore more works by this talented author.", ProductId = 10, AppUserId = "4e8b3ae2-4358-4d32-8fdf-d9a95df929e7" },
    new ProductComment { Id = 11, Rate =5, Message = "I thoroughly enjoyed the immersive world created by the author in this book. The descriptive prose and well-defined characters added depth to the narrative, making it a standout read.", ProductId = 11, AppUserId = "8dce53a3-4394-46c3-8ebd-dbb06801e22e" },
    new ProductComment { Id = 12, Rate = 4, Message = "This book offers a fresh perspective on a familiar genre. The author's innovative approach and storytelling techniques make it a compelling addition to my collection. Highly recommended!", ProductId = 12, AppUserId = "0efd01de-4eec-45ff-9de4-f03f9abdf104" },
    new ProductComment { Id = 13, Rate = 3, Message = "A captivating journey through the pages of this book. The author's ability to create a vivid and atmospheric setting enhances the overall reading experience. A must-read for those who appreciate literary craftsmanship.", ProductId = 13, AppUserId = "122ee49a-1c09-45ba-a6a5-4e94b3be7c85" },
    new ProductComment { Id = 14, Rate = 3, Message = "I was pleasantly surprised by the unique plot twists in this book. The author's storytelling prowess shines through, keeping readers engaged until the final chapter. An enjoyable read that deserves a spot on every bookshelf.", ProductId = 14, AppUserId = "4e8b3ae2-4358-4d32-8fdf-d9a95df929e7" },
    new ProductComment { Id = 15, Rate = 2, Message = "This book is a gem in contemporary literature. The author's exploration of complex themes and relatable characters resonated with me on a profound level. An enriching read that I'll cherish for years to come.", ProductId = 15, AppUserId = "8dce53a3-4394-46c3-8ebd-dbb06801e22e" }
);







        }

    }
}
