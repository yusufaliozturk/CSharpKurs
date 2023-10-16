using GameProject;

GameManager gameManager = new GameManager(new NewEStateUserValidationManager());
gameManager.Add(new Gamer
{
    Id = 1,
    BirthYear = 1984,
    FirstName = "ENGİN",
    LastName = "DEMİROĞ",
    IdentityNumber = 12345
});