using System;

namespace RPG_Poo.src.Entities

   

        
}
	public class Hero 

    {
    public Hero(string Name, int Level, string Herotype)
        
    {
        this.Name = Name;
        this.Level1 = Level1;
        this.Herotype = Herotype;

    }



        public string Name;

        public int Level1;

        public string Herotype;

    public override string ToString()
    {
        return this.Name + " " + this.Level1 + " " +this.Herotype;
    }
    public string attack()
    {
        return this.Name +  "atacoou com sua espada"
    }


    }
}