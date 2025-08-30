using System;
namespace OopsProject {
   public delegate string MyDel(string str);
	
   class Events {
      // 2. Declare the event
        public event MyDel MyEvent;

        public Events()
        {
            // 3. Subscribe in the constructor
            this.MyEvent += this.WelcomeUser;
        }

        public string WelcomeUser(string username)
        {
            return "Welcome " + username;
        }

        // 4. IMPORTANT: Add a public method to RAISE the event.
        // This encapsulates the event invocation logic.
        public string RaiseEvent(string message)
        {
            // Check if the event has any subscribers before invoking it.
            if (MyEvent != null)
            {
                // The event is invoked inside the class that owns it.
                return MyEvent(message);
            }
            return "No subscribers found."; // Or handle the null case appropriately
        }
   }
}