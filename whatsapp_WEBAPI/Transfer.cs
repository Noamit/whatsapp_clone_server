namespace whatsapp_WEBAPI
{
    public class Transfer
    {
        public int Id { get; set; }

        //the contact that send the message
        public string from { get; set; }

        //the user that get the mesaage
        public string to { get; set; }

        //the contect of the message
        public string content { get; set; }
    }
}