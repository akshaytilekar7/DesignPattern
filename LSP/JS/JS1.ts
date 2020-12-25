class UserService {
    public fetchUser = (username: String, password: String): void => {
    }

}

class ApiUserService extends UserService {

    public fetchUser = (username: String, password: String): void => {
        let name = "Api";
    }

}

class DatabaseUserService extends UserService {

    public fetchUser = (username: String, password: String): void => {
        let name = "DB";
    }
}

class UserManager {

    public service: UserService;

    constructor(service: UserService) {
        this.service = service;
    }

    public fetchUser = (username: String, password: String): void => {
        this.service.fetchUser(username, password);
    }

}

class Use {
    constructor() {
        let databaseService = new DatabaseUserService();
        let userManager = new UserManager(databaseService);
        userManager.fetchUser('A', 'P');
        //PRINTED RESULT DB REQUEST HERE

        let apiService = new ApiUserService();
        userManager = new UserManager(apiService);
        userManager.fetchUser('A', 'P');
        //PRINTED RESULT API REQUEST HERE
    }
}