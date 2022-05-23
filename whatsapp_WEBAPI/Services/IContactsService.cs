using Microsoft.AspNetCore.Mvc;

namespace whatsapp_WEBAPI.Controllers
{
    public interface IContactsService 
    {
        public Task<ActionResult<IEnumerable<ContactResponse>>?> GetContacts(string user);

        public Task<int> PostContact(Contact contact, string user);

        public Task<ActionResult<ContactResponse>>? GetContact(string id, string user);

        public Task<int> PutContact(string id, string user, PutContant contactChanged);

        public Task<int> DeleteContact(string id, string user);

        public Task<int> CheckInvitaionValid(Invitation invitation);

        public Task<Contact> postInvitation(Invitation invitation);

    }
}
