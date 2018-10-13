namespace Program1
{
	public class Client
	{
		public string Name { get; /*private*/ set; }

		#region Constructors

		public Client(Client _client)
		{
			Name = _client.Name;
		}

		public Client(string name)
		{
			Name = name;
		}

		#endregion
	}
}