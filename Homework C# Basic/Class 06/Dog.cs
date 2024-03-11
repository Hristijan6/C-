public class Dog
{

	public string DogName { get; set; }

	public string DogBreed { get; set; }

	public string DogColor { get; set; }
	public Dog()
	{
	}

	public Dog(string name, string breed, string color)
	{
		DogName = name;
		DogBreed = breed;
		DogColor = color;
	}

	public string Eat()
	{
		return $"The dog {DogName} of breed: {DogBreed} and of color: {DogColor} is now eating";
	}

	public string Play()
	{
		return $"The dog {DogName} of breed: {DogBreed} and of color: {DogColor} is now playing";
	}
	public string ChaseTail()
	{
		return $"The dog {DogName} of breed: {DogBreed} and of color: {DogColor} is now chasing it's tail";
	}
}

