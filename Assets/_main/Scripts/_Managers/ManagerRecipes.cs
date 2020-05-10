using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Managers {
    public class ManagerRecipes : MonoBehaviour
    {
        public List<Recipe_SO> allRecipes = new List<Recipe_SO>();

        private void Awake()
        {
            ManagerStatic.recipesManager = this;
        }
    }
}
