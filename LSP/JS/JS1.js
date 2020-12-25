var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var UserService = /** @class */ (function () {
    function UserService() {
        this.fetchUser = function (username, password) {
        };
    }
    return UserService;
}());
var ApiUserService = /** @class */ (function (_super) {
    __extends(ApiUserService, _super);
    function ApiUserService() {
        var _this = _super !== null && _super.apply(this, arguments) || this;
        _this.fetchUser = function (username, password) {
            var name = "Api";
        };
        return _this;
    }
    return ApiUserService;
}(UserService));
var DatabaseUserService = /** @class */ (function (_super) {
    __extends(DatabaseUserService, _super);
    function DatabaseUserService() {
        var _this = _super !== null && _super.apply(this, arguments) || this;
        _this.fetchUser = function (username, password) {
            var name = "DB";
        };
        return _this;
    }
    return DatabaseUserService;
}(UserService));
var UserManager = /** @class */ (function () {
    function UserManager(service) {
        var _this = this;
        this.fetchUser = function (username, password) {
            _this.service.fetchUser(username, password);
        };
        this.service = service;
    }
    return UserManager;
}());
var Use = /** @class */ (function () {
    function Use() {
        var databaseService = new DatabaseUserService();
        var userManager = new UserManager(databaseService);
        userManager.fetchUser('A', 'P');
        //PRINTED RESULT DB REQUEST HERE
        var apiService = new ApiUserService();
        userManager = new UserManager(apiService);
        userManager.fetchUser('A', 'P');
        //PRINTED RESULT API REQUEST HERE
    }
    return Use;
}());
//# sourceMappingURL=JS1.js.map