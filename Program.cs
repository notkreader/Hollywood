using Hollywood.EFContext;
using Hollywood.Models.Cinemas;
using static System.Console;

CinemaContext ctx = new CinemaContext();

//DESCOMENTAR NO 1º RUN E COMENTAR A SEGUIR
/*
Movie spiderMan = new Movie{Name = "Spider-Man: No Way Home", Duration = 155, Type = MovieType.HEROES};
Movie freeGuy = new Movie{Name = "Free Guy", Duration = 145, Type = MovieType.COMEDY};
Movie uncharted = new Movie{Name = "Uncharted", Duration = 150, Type = MovieType.ACTION};
Movie joker = new Movie{Name = "Joker", Duration = 120, Type = MovieType.DRAMA};

Cinema lisboaCinema = new Cinema{Name = "Cinemas NOS"};
Cinema madridCinema = new Cinema{Name = "Cine Fiesta"};

ctx.AddRange(spiderMan, freeGuy, uncharted, joker, lisboaCinema, madridCinema);
*/

//COMENTAR NO 1º RUN E DESCOMENTAR NO 2º RUN E NÃO COMENTAR A SEGUIR

Movie spiderMan = ctx.Movies.Find(1);
Movie freeGuy = ctx.Movies.Find(2);
Movie uncharted = ctx.Movies.Find(3);
Movie joker = ctx.Movies.Find(4);

Cinema lisboaCinema = ctx.Cinemas.Find(1);
Cinema madridCinema = ctx.Cinemas.Find(2);


//DESCOMENTAR NO 3º RUN E COMENTAR A SEGUIR
/*
CinemaMovie freeGuyAtLisboa = new CinemaMovie{CinemaId = lisboaCinema.CinemaId, MovieId = freeGuy.MovieId};
CinemaMovie freeGuyAtMadrid = new CinemaMovie{CinemaId = madridCinema.CinemaId, MovieId = freeGuy.MovieId};
CinemaMovie spiderManAtMadrid = new CinemaMovie{CinemaId = madridCinema.CinemaId, MovieId = spiderMan.MovieId};

ctx.AddRange(freeGuyAtLisboa, freeGuyAtMadrid, spiderManAtMadrid);
*/

WriteLine("FREE GUY AVAILABLE AT:");
foreach(var a in ctx.CinemaMovies.ToList().Where(b => b.MovieId == freeGuy.MovieId)){
    WriteLine(ctx.Cinemas.Find(a.CinemaId).Name);
}

WriteLine("-------------------------------------");

WriteLine("SPIDER-MAN NO WAY HOME AVAILABLE AT:");
foreach(var a in ctx.CinemaMovies.ToList().Where(b => b.MovieId == spiderMan.MovieId)){
    WriteLine(ctx.Cinemas.Find(a.CinemaId).Name);
}


ctx.SaveChanges();



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
