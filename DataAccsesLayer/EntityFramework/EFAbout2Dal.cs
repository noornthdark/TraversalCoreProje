using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccsesLayer.Abstract;
using DataAccsesLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccsesLayer.EntityFramework
{
    public class EFAbout2Dal : GenericRepository<About2>, IAbout2Dal
    {
    }
}
