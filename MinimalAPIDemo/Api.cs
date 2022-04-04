namespace MinimalAPIDemo;

public static class Api
{
    public static void ConfigureApi(this WebApplication app)
    {
        app.MapGet("/Person", GetPeople);
        app.MapGet("/Person/{id}", GetPerson);
        app.MapGet("/Person/Find", SearchForPerson);
        app.MapPost("/Person", InsertPerson);
        app.MapPut("/Person", UpdatePerson);
        app.MapDelete("/Person", DeletePerson);
    }

    private static async Task<IResult> GetPeople(IPersonData data)
    {
        try
        {
            return Results.Ok(await data.GetPeople());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetPerson(int id, IPersonData data)
    {
        try
        {
            var result = await data.GetPerson(id);
            if (result == null) return Results.NotFound();
            return Results.Ok(result);
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> SearchForPerson(string searchTerm, IPersonData data)
    {
        try
        {
            var result = await data.Search(searchTerm);
            if (result == null) return Results.NotFound();
            return Results.Ok(result);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertPerson(Person user, IPersonData data)
    {
        try
        {
            
            return Results.Ok(await data.InsertPerson(user));
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> UpdatePerson(Person user, IPersonData data)
    {
        try
        {
            await data.UpdatePerson(user);
            return Results.Ok(user);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeletePerson(int id, IPersonData data)
    {
        try
        {
            await data.DeletePerson(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }
}
