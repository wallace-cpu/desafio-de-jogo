using System;

namespace RPG_Poo.src.Entities
{
	public wizard : Hero
	{
	public wizard((string Name, int Level, string Herotype))
    {
		this.Name = Name;
		this.Level1 = Level1;
		this.Herotype = Herotype;

	}
	public string attack()
	{
		return this.Name + "atacoou com magia"

	}
	public string Attack(int Bonus)
    {
        if(Bonus > 6)
		{
			return this.Name + "lançou magia com bonus de attack " + Bonus;
        }
        else
        {
			return this.Name + "lançou magia fraca de attack " + Bonus;
		}
		

	}


}
}
