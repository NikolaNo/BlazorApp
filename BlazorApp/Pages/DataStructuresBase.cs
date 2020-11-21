using BlazorApp.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public class DataStructuresBase : ComponentBase
    {


        protected override void OnInitialized()
        {
            LoadStructures();
            base.OnInitialized();
        }
        public List<DataStructureModel> model = new List<DataStructureModel>();
               
        
        public void LoadStructures()
        {
            DataStructureModel DFS = new DataStructureModel()
            {
                ID = 1,
                Name = "DFS",
                Photo = "img/DFS.PNG"
            };
            DataStructureModel BFS = new DataStructureModel()
            {
                ID = 2,
                Name = "BFS",
                Photo = "img/BFS.PNG"
            };
            DataStructureModel LinkedList = new DataStructureModel()
            {
                ID = 3,
                Name = "LinkedList",
                Photo = "img/BFS.PNG"
            };

            model = new List<DataStructureModel> { DFS, BFS, LinkedList };
        }


    }
}
