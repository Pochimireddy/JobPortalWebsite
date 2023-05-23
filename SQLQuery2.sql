create database JobPortalWebsite2
use JobPortalWebsite2

CREATE TABLE job_seeker (
    job_seeker_id INT PRIMARY KEY identity(1,1),
    username VARCHAR(50) NOT NULL,
    password VARCHAR(50) NOT NULL,
    full_name VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL,
    phone_number VARCHAR(20) NOT NULL,
    address VARCHAR(200) NOT NULL,
    education_level VARCHAR(50) NOT NULL,
    experience INT NOT NULL,
    resume VARCHAR(200) NOT NULL
);
select * from job_seeker
select * from company
select * from job
select * from application
select * from message
select * from interview
select * from admin



CREATE TABLE company (
    company_id INT PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(50) NOT NULL,
    company_name VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL,
    phone_number VARCHAR(20) NOT NULL,
    address VARCHAR(200) NOT NULL,
    description VARCHAR(200) NOT NULL,
    industry VARCHAR(50) NOT NULL
);

CREATE TABLE job (
    job_id INT PRIMARY KEY,
    company_id INT NOT NULL,
    job_title VARCHAR(100) NOT NULL,
    job_description TEXT NOT NULL,
    job_requirements TEXT NOT NULL,
    job_location VARCHAR(200) NOT NULL,
    salary_range VARCHAR(50) NOT NULL,
    employment_type VARCHAR(50) NOT NULL,
    created_at DATETIME NOT NULL,
    expiration_date DATETIME NOT NULL,
    FOREIGN KEY (company_id) REFERENCES company(company_id)
);

CREATE TABLE application (
    application_id INT PRIMARY KEY,
    job_id INT NOT NULL,
    job_seeker_id INT NOT NULL,
    cover_letter VARCHAR(200) NOT NULL,
    resume VARCHAR(200) NOT NULL,
    applied_date DATETIME NOT NULL,
    FOREIGN KEY (job_id) REFERENCES job(job_id),
    FOREIGN KEY (job_seeker_id) REFERENCES job_seeker(job_seeker_id)
);

CREATE TABLE message (
    message_id INT PRIMARY KEY,
    sender_id INT NOT NULL,
    receiver_id INT NOT NULL,
    message_body TEXT NOT NULL,
    sent_date DATETIME NOT NULL,
    FOREIGN KEY (sender_id) REFERENCES job_seeker(job_seeker_id),
    FOREIGN KEY (receiver_id) REFERENCES company(company_id)
);

CREATE TABLE interview (
    interview_id INT PRIMARY KEY,
    application_id INT NOT NULL,
    interviewer_id INT NOT NULL,
    interview_date DATE NOT NULL,
    interview_time TIME NOT NULL,
    interview_location VARCHAR(200) NOT NULL,
    interview_notes TEXT,
    FOREIGN KEY (application_id) REFERENCES application(application_id),
    FOREIGN KEY (interviewer_id) REFERENCES company(company_id)
);

CREATE TABLE admin (
    admin_id INT PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(50) NOT NULL,
    full_name VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL,
    phone_number VARCHAR(20),
    address VARCHAR(200)
);
create table jobseeker(ID int identity(1,1) primary key,UserName varchar(100),Password varchar(100),Address varchar(20),IsActive int)
drop table jobseeker

 -------------------

create proc Registration(@UserName varchar(100),@Password varchar(100) ,@Address varchar(20),@IsActive int)
As
begin
Insert into jobseeker( UserName,Password,Address,IsActive) values(@UserName,@Password,@Address,@IsActive);
end

 

create proc jobseekerLogin(@UserName varchar(100),@Password varchar(100))
As
begin
select * from jobseeker where UserName=@UserName and Password=@Password;
end

----------------------



create proc Admin1(@UserName varchar(100),@Password varchar(100) ,@Address varchar(20),@IsActive int)
As
begin
Insert into Employee ( UserName,Password,Address,IsActive) values(@UserName,@Password,@Address,@IsActive);
end


-----

create database JPW
use  JPW

create table Employee(ID int identity(1,1) primary key,UserName varchar(100),Password varchar(100),Email varchar(20),MobileNumber varchar(10))
drop table Employee

create proc Login(@UserName varchar(100),@Password varchar(100))
As
begin
select * from Employee where UserName=@UserName and Password=@Password;
end

create proc Registration(@UserName varchar(100),@Password varchar(100) ,@Email varchar(20), @MobileNumber varchar(10))
As
begin
Insert into Employee ( UserName,Password,Email,MobileNumber) values(@UserName,@Password,@Email,@MobileNumber);
end

drop  proc Registration

select * from Employee
 
Insert into Employee ( UserName,Password,Email,MobileNumber) values('vijay','vij678','vijay12@gmail.com','9100578433');

create TABLE job_seeker (
    job_seeker_id INT PRIMARY KEY identity(1,1),
    username VARCHAR(50) NOT NULL,
    password VARCHAR(50) NOT NULL,
    full_name VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL,
    phone_number VARCHAR(20) NOT NULL,
    address VARCHAR(200) NOT NULL,
    education_level VARCHAR(50) NOT NULL,
    experience INT NOT NULL,
    resume VARCHAR(200) NOT NULL
);
Insert into job_seeker ( username,Password,full_name,email,phone_number,address,education_level,experience,resume) 
values('vijay','vij678','vijayreddy','vijay12@gmail.com',9100578933,'blr','btech',0,'uploaded');
select * from job_seeker

select * from job_seeker

CREATE TABLE company (
    company_id INT PRIMARY KEY identity(1,1) NOT NULL,
    username VARCHAR(50) NOT NULL,
    password VARCHAR(50) NOT NULL,
    company_name VARCHAR(100) NOT NULL,
    email VARCHAR(100) NOT NULL,
    phone_number int  NOT NULL,
    address VARCHAR(200) NOT NULL,
    description VARCHAR(200) NOT NULL,
    industry VARCHAR(50) NOT NULL
);
drop table company
select * from company
select * from job_seeker
select * from Employee

create proc adminlogin(@UserName varchar(100),@Password varchar(100))
As
begin
select * from Admin where UserName=@UserName and Password=@Password;
end	
	
create table Admin (UserName varchar(10),Password varchar(15))
insert into Admin values('kumar','kumar1@')

select * from Admin

drop proc adminlogin