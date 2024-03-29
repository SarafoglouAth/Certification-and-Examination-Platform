﻿using System.ComponentModel.DataAnnotations;
using Data.Models.Shared;


namespace Data.Models;

public class Candidate : AuditBase
{
    public int UserId { get; set; }
    public virtual User User { get; set; } = null!;

    [MaxLength(200)]
    public string FirstName { get; set; } = null!;
    [MaxLength(200)]
    public string MiddleName { get; set; } = null!;
    [MaxLength(200)]
    public string LastName { get; set; } = null!;
    [MaxLength(50)]
    public string Gender { get; set; } = null!;
    [MaxLength(50)]
    public string NativeLanguage { get; set; } = null!;
    public string PhotoIDType { get; set; } = null!;
    public string PhotoIDNumber { get; set; } = null!;
    public DateOnly BirthDate { get; set; }
    public DateOnly PhotoIDIssueDate { get; set; }
    [EmailAddress]
    public string Email { get; set; } = null!;
    [MaxLength(200)]
    public string Address { get; set; } = null!;
    [MaxLength(200)]
    public string? AddressLine2 { get; set; }
    [MaxLength(200)]
    public string CountryOfResidence { get; set; } = null!;
    [MaxLength(200)]
    public string State { get; set; } = null!;
    [MaxLength(200)]
    public string Territory { get; set; } = null!;
    [MaxLength(200)]
    public string Province { get; set; } = null!;
    [MaxLength(200)]
    public string TownCity { get; set; } = null!;
    [MaxLength(200)]
    public string PostalCode { get; set; } = null!;
    [MaxLength(200)]
    public string? LandlineNumber { get; set; }
    [MaxLength(200)]
    public string MobileNumber { get; set; } = null!;

    public virtual ICollection<CandidateExam> CandidateExams { get; set; } = new List<CandidateExam>();
    public virtual ICollection<CandidateExamsDetails> CandidateExamsDetails { get; set; } = new List<CandidateExamsDetails>();
}
