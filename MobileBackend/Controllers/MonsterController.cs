using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileBackend.Controllers
{
    public class MonsterController : Controller
    {

        private ApplicationContext _dbContext;

        public MonsterController(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }


        [HttpGet("getMonsters")]
        public List<DAL3.Models.Monster> GetAllMonsters(int monsterId)
        {
            return _dbContext.Monster.ToList();
        }
    }

}
