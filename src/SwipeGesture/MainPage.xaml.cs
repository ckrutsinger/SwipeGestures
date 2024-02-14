using System.Diagnostics;

namespace SwipeGesture
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public List<string> Items {  get; set; } = ["alpha", "bravo", "charlie", "delta", "echo", "foxtrot", "golf", "hotel", "india", "juliet", "kilo", "lima", "mike", "november"];

        public MainPage()
        {
            InitializeComponent();
        }

        private void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            Debug.Write($"swiped {e.Direction}");
        }

        private void RefreshView_Refreshing(object sender, EventArgs e)
        {
            //refreshView.IsRefreshing = false;
        }
    }

}
