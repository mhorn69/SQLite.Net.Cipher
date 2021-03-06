using SQLite.Net.Cipher.Data;
using SQLite.Net.Cipher.Interfaces;
using SQLite.Net.Interop;

namespace SQLiteNetCipher.Windows.Sample.Windows.Sample
{
	public class MyDatabase : SecureDatabase
	{
		public MyDatabase(ISQLitePlatform platform, string dbfile, ICryptoService cryptoService) : base(platform, dbfile, cryptoService)
		{
		}

		protected override void CreateTables()
		{
			CreateTable<SampleUser>();
		}
	}
}