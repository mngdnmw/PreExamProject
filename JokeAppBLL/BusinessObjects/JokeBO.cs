using System;
namespace JokeAppBLL.BusinessObjects
{
    public class JokeBO: IBusinessObject
    {

        public int Id { get ; set; }
        public String Text { get; set; }
        public bool Funny { get; set; }
    }
}
