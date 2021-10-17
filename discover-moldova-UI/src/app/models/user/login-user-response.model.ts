import { User } from "./user.model";

export class LoginResponseViewModel {
    token!: string;
    //tokenExpireDate!: Date;
    userDto!: User;
}
