using System;

abstract class Production
{
        public int readonly id
        public int autoink = 1
        public string name
        public List<byte> recipeList
        public byte activeRecipe
        public double efficiency

    public Production(string name, List<byte> recipeList, byte activeRecipe, double efficiency)
	{
        id = autoink++;
        this.name = name;
        this.recipeList = recipeList;
        this.activeRecipe = activeRecipe;
        this.efficiency = efficiency;
    }
}
