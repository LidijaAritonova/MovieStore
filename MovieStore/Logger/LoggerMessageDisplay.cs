using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieStore.Logger
{
    public class LoggerMessageDisplay
    {
        public const string MovieListed = "All movies listed successfully!";
        public const string NoMovie = "There is no movies in the DB!";

        public const string MovieDisplayDetails = "Movie was found in the DB, show the details of the book";
        public const string NoMovieFound = "This is no movie found in the DB!";

        public const string MovieAdd = "New movie is added in the DB";
        public const string MovieNotCreatedModelStateInvalid = "New movie is NOT created in the DB, ModelState is not valid";

        public const string PhotoUploaded = "Photo is successfully uploaded";
        public const string PhotoUploadedError = "Photo is NOT uploaded";

        
        public const string MovieEditNotFound = "Movie for editting is not found in the DB";
        public const string MovieEditErrorModelStateInvalid = "Movie is not edited, ModelState is not valid";
        public const string MovieEdited = "Movie is edited successfully";


        public const string MovieDeleted = "Movie is deleted successfully";
        public const string MovieDeletedError = "Movie is NOT deleted, error happend in process of deletion";



        public const string UsersListed = "All users listed successfully!";
        public const string NoUsersInDB = "There is no user in the DB!";
        public const string UserFoundDisplayDetails = "User was found in the DB, show the details of the user";
        public const string NoUserFound = "This is no user found in the DB!";
        public const string UserCreated = "New user is created in the DB";
        public const string UserNotCreatedModelStateInvalid = "New user is NOT created in the DB, ModelState is not valid";
        public const string UserEdited = "User is edited successfully";
        public const string UserEditErrorModelStateInvalid = "User is not edited, ModelState is not valid";
        public const string UserDeleted = "User is deleted successfully";
        public const string UserDeletedError = "User is NOT deleted, error happend in process of deletion";

    }
}
