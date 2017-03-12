using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

namespace PaneraBread
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void ReplTest()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{
			app.Tap(x => x.Id("our_menu"));
			app.Screenshot("Tapped on 'Our Menu' Button");
			Thread.Sleep(2000);

			app.ScrollDown();
			app.Screenshot("Srolled down the menu to 'Pastas'");

			app.Tap("Pastas");
			app.Screenshot("Tapped on 'Pastas'");

			app.Tap("customize_button");
			app.Screenshot("Tapped on 'Customize' Button for 'Chicken Tortellini Alfredo'");
			Thread.Sleep(2000);

			app.ScrollDown();
			app.Screenshot("Scrolling down to 'Special Instructions'");

			app.Tap("special_instructions");
			app.Screenshot("Tapped on 'Special Instructions'");

			app.Tap("prepared_for");
			app.Screenshot("Tapped on 'Prepared For' Text Field");

			app.EnterText("'Microsoft loves Panera Bread");
			app.Screenshot("Typed 'Microsoft loves Panera Bread'");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");
			Thread.Sleep(2000);

			app.Tap("done_button");
			app.Screenshot("Tapped on 'Done' Button");
			Thread.Sleep(2000);

			app.ScrollUp();
			app.Screenshot("Scrolled back up to the top of the item");

			app.Tap("add_to_order_id");
			app.Screenshot("Tapped on 'Add to Order' Button");

			app.Tap("button_4");
			app.Screenshot("Tapped on 'Select Cafe'");
			Thread.Sleep(2000);

			app.Tap("search");
			app.Screenshot("Tapped on Text Field");

			app.EnterText("94111");
			app.Screenshot("Entered '94111'");

			app.DismissKeyboard();
			app.Screenshot("Dismissed Keyboard");

			app.Tap("search_button");
			app.Screenshot("Tapped on Search Button");


			//app.Tap("footer_button");
			//app.Screenshot("Tapped on 'View Cart'");

			//app.Tap("footer_button");
			//app.Screenshot("Tapped on 'Checkout'");

			//app.Tap("button_3");
			//app.Screenshot("Tapped on 'Continue as Guest' Button");

			//app.Tap("item_text_field");
			//app.Screenshot("Tapped on 'Select Payment Method'");

			//app.Tap("Add Credit Card");
			//app.Screenshot("Tapped on 'Add Credit Card' Button");

			//app.EnterText("8888888888888888");
			//app.Screenshot("Typed in my credit card number");


		}

	}
}
