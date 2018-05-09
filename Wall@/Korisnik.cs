using System;

public class Korisnik
{

    private int ID { get; set; }
    public string Ime { get; set; }
    public string Prezime { get; set; }
    public string Email { get; set; }
    private string Lozinka { get; set; }

    public Korisnik(int ID, string Ime, string Prezime, string Email, string Lozinka)
	{
        this.ID = ID;
        this.Ime = Ime;
        this.Prezime = Prezime;
        this.Email = Email;
        this.Lozinka = Lozinka;
	}
}
