using Infrastructure.Services.Common;
using Infrastructure.Services.UserServices;

namespace Infrastructure.Services.Friendship
{
    public interface IFriendshipService :IService
    {
        Task<IList<UserServiceModel>> GetFriendsAsync(string userId);

        Task<ICollection<UserServiceModel>> GetNonFriendsAsync(string userId);

        Task<ServiceModelFriendshipStatus> GetFriendshipStatusAsync(string currentUserId, string secondUserId);

        Task<IEnumerable<UserServiceModel>> GetFriendRequestsAsync(string currentUserId);

        Task<IEnumerable<UserServiceModel>> GetPendingRequestsAsync(string currentUserId);

        Task<IEnumerable<UserServiceModel>> GetFriendsByPartNameAsync(string partName, string userId);

        Task SendRequestAsync(string currentUserId, string addresseeId);

        Task AcceptRequestAsync(string currentUserId, string requesterId);

        Task RejectRequestAsync(string currentUserId, string requesterId);

        Task CancelInvitationAsync(string currentUserId, string addresseeId);

        Task UnfriendAsync(string currentUserId, string friendId);
    }
}