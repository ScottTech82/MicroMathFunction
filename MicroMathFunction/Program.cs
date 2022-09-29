var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//might need CORS if we are actually going to deploy this.

var app = builder.Build();

// Configure the HTTP request pipeline.

app.MapGet("/modulo/{num:int}/{denom:int}", (int num, int denom) =>
{
    if(denom == 0)
    {
        return Results.BadRequest("2nd parameter cannot be zero");
    }
    return Results.Ok(num % denom);

});

app.MapGet("/cubed/{nbr:decimal}", (decimal nbr) =>
{
    return nbr * nbr * nbr;
});



app.Run();



