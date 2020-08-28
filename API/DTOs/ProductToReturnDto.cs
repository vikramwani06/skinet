namespace API.DTOs
{
    //DTO : Data Transfer Object - A container to move data between layers
    // Does not contain any buisness logic. They only contain getters and setters
    public class ProductToReturnDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureURL { get; set; }
        public string ProductType { get; set; }
        public string ProductBrand { get; set; }
    }
}