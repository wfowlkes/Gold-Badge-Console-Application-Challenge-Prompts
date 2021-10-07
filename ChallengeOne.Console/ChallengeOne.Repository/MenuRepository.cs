using ChallengeOneRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeOneRepository
{
    public class MenuRepository
    {

        public readonly List<Menu> _contentDirectory = new List<Menu>();

        //add
        public bool AddContentToDirectory(Menu menu)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(menu);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        //viewAll
        public List<Menu> GetContents()
        {
            return _contentDirectory;
        }
        //delete
        public bool DeleteContent(Menu existingContent)
        {
            bool result = _contentDirectory.Remove(existingContent);
            return result;
        }
        public string GetByDescription()
        {
            Menu searchResult = new Menu();

            return searchResult.Description;
        }
    }
}

          

