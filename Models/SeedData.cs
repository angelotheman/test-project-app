using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider){
        using var context = new MvcMovieContext(serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>());
        // Look for any movies
        if (context.Movie.Any()) { return; }
        context.Movie.AddRange(
            new Movie
            {
                Title = "When I met my love",
                ReleaseDate = DateTime.Parse("2000-05-30"),
                Genre = "Commedy",
                Price = 22
            },
            new Movie
            {
                Title = "Truth vs Error",
                ReleaseDate = DateTime.Parse("2013-10-03"),
                Genre = "Educative",
                Price = 564
            }, new Movie
            {
                Title = "The role of politicians",
                ReleaseDate = DateTime.Parse("2019-03-22"),
                Genre = "Classic",
                Price = 500
            }, new Movie
            {
                Title = "The deathhhhh of Ananse",
                ReleaseDate = DateTime.Parse("2014-08-22"),
                Genre = "Tragic-Commedy",
                Price = 247
            }, new Movie
            {
                Title = "Into the badlands",
                ReleaseDate = DateTime.Parse("1995-10-20"),
                Genre = "Tragic",
                Price = 894
            }
        );
        context.SaveChanges();
    }
}