import { PatientRating } from './patientRating';

export interface DoctorDetail {
    name: string;
    gender: string;
    medicalSchool: string;
    languages: string[];
    specialties: string[];
    patientRatings: PatientRating[];
    average: number;
}
