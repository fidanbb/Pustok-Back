namespace Pustok_Backend.Areas.Admin.ViewModels.ProductComment
{
    public class ProductCommentVM
    {
        public int Id { get; set; }
        public string ProductTitle { get; set; }
        public string Message { get; set; }
        public int Rate { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
