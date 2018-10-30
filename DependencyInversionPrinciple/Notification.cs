namespace DependencyInversionPrinciple
{
    /* https://exceptionnotfound.net/simply-solid-the-dependency-inversion-principle/
     *Notice that the Notification class, a higher-level class, has a dependency on both the Email class and the SMS class, which are lower-level classes.
     * In other words, Notification is depending on the concrete implementation of both Email and SMS, not an abstraction of said implementation.
     * Since DIP wants us to have both high and low-level classes depend on abstractions, we are currently violating this principle.

     * The two classes are said to have high-coupling.
     * Remember from the post on the Single Responsibility Principle that we don't want such coupling in our code if it can be avoided,
     * since that increases the risk that both of these classes will need to change if one of them changes implementation.

     * (One trick you can use to determine how tightly coupled your code is is to look for the new keyword. Generally speaking, the more instances of new keyword you have,
     * the more tightly coupled your code is.) 
     *  
     */
    class Notification
    {
        private Email _email;
        private SMS _sms;
        public Notification()
        {
            _email = new Email();
            _sms = new SMS();
        }

        public void Send()
        {
            _email.SendEmail();
            _sms.SendSMS();
        }
    }
}
