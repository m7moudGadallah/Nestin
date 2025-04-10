export interface Iuser {
    id: string; // UUID primary key
    firstName: string; // First name, max length 100
    lastName: string; // Last name, max length 100
    email: string; // Email, not null
    password: string; // Password, not null
    photoId?: number; // Photo ID, optional
    joinedAt: Date; // Joined at, not null
}
