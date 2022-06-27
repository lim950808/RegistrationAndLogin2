# RegistrationAndLogin2
Login and Registration in ASP.NET MVC Application with SQL Server
<pre>

</pre>
<hr>
<h2>Table</h2>
SET ANSI_NULLS ON  <br>
GO  <br>
  
SET QUOTED_IDENTIFIER ON  <br>
GO  <br>
  
SET ANSI_PADDING ON  <br>
GO  <br>
  
CREATE TABLE [dbo].[Enrollment](  <br>
    [ID] [int] IDENTITY(1,1) NOT NULL,  <br>
    [FirstName] [varchar](50) NULL,  <br>
    [LastName] [varchar](50) NULL,  <br>
    [Password] [nvarchar](30) NULL,  <br>
    [Email] [nvarchar](50) NULL,  <br>
    [Phone] [varchar](15) NULL,  <br>
    [SecurityAnwser] [nvarchar](50) NULL,  <br>
    [Gender] [varchar](15) NULL,  <br>
PRIMARY KEY CLUSTERED   <br>
(  <br>
    [ID] ASC  <br>
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]  <br>
) ON [PRIMARY]  <br>
  
GO  <br>
  
SET ANSI_PADDING OFF  <br>
GO <br>
;<br>

<pre>

</pre>
<hr>
<h2>Procedure</h2>
SET ANSI_NULLS ON  <br>
GO  <br>
SET QUOTED_IDENTIFIER ON  <br>
GO  <br>
  
create procedure [dbo].[SP_EnrollDetail]  <br>
(  <br>
	@FirstName varchar(50)=NULL,  <br>
	@LastName varchar(50)=NULL,  <br>
	@Password varchar(50)=NULL,  <br>
	@Gender varchar(10)=NULL,  <br>
	@Email nvarchar(50)=NULL,  <br>
	@Phone varchar(15)=NULL,  <br>
	@SecurityAnwser nvarchar(50)=NULL,  <br>
	@status varchar(15)  <br>
)  <br>
as  <br>
begin  <br>
	if @status='Insert'  <br>
	begin  <br>
		insert into Enrollment(FirstName,LastName,Password,Gender,Email,Phone,SecurityAnwser)values(@FirstName,@LastName,@Password,@Gender,@Email,@Phone,@SecurityAnwser)  <br>
	end  <br>
end<br>
;<br>


SET ANSI_NULLS ON  <br>
GO  <br>
SET QUOTED_IDENTIFIER ON  <br>
GO  <br>
create procedure [dbo].[sp_GetEnrollmentDetails]  <br>
	(@Email nvarchar(50))  <br>
as  <br>
begin  <br>
	select * from Enrollment where Email=@Email  <br>
end <br>
;<br>
