using System;

namespace Prime.Services
{
    public class HomeController  
    {  
        private readonly IGetDataRepository _data;  
  
        public HomeController(IGetDataRepository data)  
        {  
            _data = data;  
        }  
        public string GetNameById(int id)  
        {  
            return _data.GetNameById(id);  
        }  
    } 
}