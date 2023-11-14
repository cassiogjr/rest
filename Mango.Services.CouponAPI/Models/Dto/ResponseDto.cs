namespace Mango.Services.CouponAPI.Models.Dto
{
    public class ResponseDto
    {
        public Object? Result { get; set; }
        public bool IsSucess { get; set; } = true;
        public string Message { get; set; } = "";

    }
}
