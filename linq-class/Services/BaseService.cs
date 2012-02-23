using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using linq_class.Entities;

namespace linq_class.Services
{
    public class BaseService
    {
        protected Context _context;

        public BaseService(Context context)
        {
            this._context = context;
        }
    }
}
