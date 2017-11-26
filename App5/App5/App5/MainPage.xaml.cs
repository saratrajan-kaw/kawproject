using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json;

namespace App5
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            //System.Net.ServicePointManager.DnsRefreshTimeout = 0;
		}

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //var entry = new Label();
            //entry.Text = "HelloWorld";
            //rootLayout.Children.Add(entry);

            var email = Username.Text;
            var pwd = Password.Text;
            var data = await PostLoginAsync("", email, pwd);

            //var data = await PostLoginAsync("", "itsme.emil@gmail.com", "emil123");

            if (!string.IsNullOrEmpty(data))
            {

                KAWMember member = JsonConvert.DeserializeObject<KAWMember>(data);
                if (member != null)
                {
                    var FirstName = new Label { Text = "FirstName: " + member.FirstName };
                    var LastName = new Label { Text = "LastName: " + member.LastName };
                    var Address = new Label { Text = "Address: " + member.Address };
                    var MemberId = new Label { Text = "MemberId: " + member.MemberId };
                    var MembershipLastPaidDate = new Label { Text = "MembershipLastPaidDate: " + member.MembershipLastPaidDate };
                    var Phone = new Label { Text = "Phone: " + member.Phone };

                    rootLayout.Children.Add(FirstName);
                    rootLayout.Children.Add(LastName);
                    rootLayout.Children.Add(Address);
                    rootLayout.Children.Add(MemberId);
                    rootLayout.Children.Add(MembershipLastPaidDate);
                    rootLayout.Children.Add(Phone);

                }
            }
        }

        private async Task<string> PostLoginAsync(string url, string email, string pwd)
        {
            try
            {

                var client = new HttpClient();
             //   client.BaseAddress = new Uri("http://mobileservice20171118105911.azurewebsites.net");
                System.Json.JsonObject jsonObject = new System.Json.JsonObject() { { "username", email }, { "password", pwd } };
                string jsonData = jsonObject.ToString();
                // string jsonData = @"{""username"" : ""myusername"", ""password"" : ""mypassword""}";

                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("http://mobileservice20171118105911.azurewebsites.net/api/login", content);

                // this result string should be something like: "{"token":"rgh2ghgdsfds"}"
                var result = await response.Content.ReadAsStringAsync();
                return result;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }


    public class KAWMember
    {
        public string MemberId
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public string Avatar
        {
            get;
            set;
        }

        public string Phone
        {
            get;
            set;
        }

        public string Address
        {
            get;
            set;
        }

        public string MembershipYear
        {
            get;
            set;
        }

        public bool IsVerified
        {
            get;
            set;
        }

        public bool IsActive
        {
            get;
            set;
        }

        public bool IsDeleted
        {
            get;
            set;
        }

        public string MembershipLastPaidDate
        {
            get;
            set;
        }

        public bool MembershipPaid
        {
            get;
            set;
        }

        public string PaymentMode
        {
            get;
            set;
        }

        public string TransactionId
        {
            get;
            set;
        }

        public string PaymentId
        {
            get;
            set;
        }

        public string PaymentAmount
        {
            get;
            set;
        }

        public string LastPaymentDate
        {
            get;
            set;
        }
    }



}
