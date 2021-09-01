select FavouriteLabel, RecipeUri, COUNT (RecipeUri) as total from FavouritesList
group by RecipeUri, FavouriteLabel
order by total desc
