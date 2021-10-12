import { User } from "./user.model";

export class LoginResponseViewModel {
    token!: string;
    user!: User;
}