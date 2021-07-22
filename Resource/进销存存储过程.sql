--1
create procedure GetAllCategory
as
select * from TBL_Category
go

exec GetAllCategory
go


--2
create procedure InsertCategory
@CategoryID nvarchar(6),
@CategoryName nvarchar(80)
as
insert TBL_Category
values(@CategoryID,@CategoryName)
go

exec InsertCategory '4','����'
go

--3
create procedure DeleteCategory
@CategoryID nvarchar(6)
as
delete TBL_Category
where CategoryID=@CategoryID
go

exec DeleteCategory '4'
go

--4
create procedure FindCategoryByCategoryID
@CategoryID nvarchar(6)
as
select * from TBL_Category
where CategoryID=@CategoryID 
go

exec FindCategoryByCategoryID '1'


--5
create procedure UpdateCategory
@CategoryID nvarchar(6),
@CategoryName nvarchar(80)
as
update TBL_Category
set CategoryName=@CategoryName
where CategoryID=@CategoryID
go

exec UpdateCategory '3','����'
go




--6
create procedure GetAllCustomer
as
select * from TBL_Customer
go

exec GetAllCustomer
go

--7
create procedure InsertCustomer
@CustomerID nvarchar(6),
@CustomerName nvarchar(80),
@SpellingCode nvarchar(20),
@Address nvarchar(80),
@ZipCode char (6),
@Tel nvarchar(20),
@Fax nvarchar(20),
@BankName nvarchar(40),
@BankAccount nvarchar(50),
@Contacter nvarchar(20),
@Email nvarchar(30)
as
insert TBL_Customer
values(@CustomerID,@CustomerName,@SpellingCode,@Address,@ZipCode,@Tel,@Fax,@BankName,@BankAccount,@Contacter,@Email)
go

exec InsertCustomer '001','����','333','����','123','123456789','888','�������','5','�淶','123@qq.com'
go



--8
create procedure DeleteCustomer
@CustomerID nvarchar(6)
as
delete TBL_Customer
where CustomerID=@CustomerID
go

exec DeleteCustomer '001'


--9
create procedure FindCustomerByCustomerID
@CustomerID nvarchar(6)
as
select * from TBL_Customer
where CustomerID=@CustomerID
go

exec FindCustomerByCustomerID '001'


--10
create procedure UpdateCustomer
@CustomerID nvarchar(6),
@CustomerName nvarchar(80),
@SpellingCode nvarchar(20),
@Address nvarchar(80),
@ZipCode char (6),
@Tel nvarchar(20),
@Fax nvarchar(20),
@BankName nvarchar(40),
@BankAccount nvarchar(50),
@Contacter nvarchar(20),
@Email nvarchar(30)
as
update TBL_Customer
set CustomerName=@CustomerName,
    SpellingCode=@SpellingCode,
    Address=@Address,
    ZipCode=@ZipCode,
    Tel=@Tel,
    Fax=@Fax,
    BankName=@BankName,
    BankAccount=@BankAccount,
    Contacter=@Contacter,
    Email=@Email
where @CustomerID=CustomerID
go

exec UpdateCustomer '001','����','333','����','123','123456789','888','�������','5','�淶','123@qq.com'
go


--11
create procedure GetAllEmployee
as
select * from TBL_Employee
go

exec GetAllEmployee

--12
create procedure InsertEmployee
@EmployeeID nvarchar(6),
@EmployeeName nvarchar(80),
@sex bit,
@Birthday datetime,
@Brief nvarchar(max)
as
insert TBL_Employee
values(@EmployeeID,@EmployeeName,@sex,@Birthday,@Brief)
go

exec InsertEmployee '001','С��',1,'1998-6-6','123'
go

--13
create procedure DeleteEmployee
@EmployeeID nvarchar(6)
as
delete TBL_Employee
where EmployeeID=@EmployeeID 
go

exec DeleteEmployee '001'
go

--14
create procedure FindEmployeeByEmployeeID
@EmployeeID nvarchar(6)
as
select * from TBL_Employee
where EmployeeID=@EmployeeID 
go

exec FindEmployeeByEmployeeID '001'
go

--15
create procedure UpdateEmployee
@EmployeeID nvarchar(6),
@EmployeeName nvarchar(80),
@sex bit,
@Birthday datetime,
@Brief nvarchar(max)
as
update TBL_Employee
set EmployeeName=@EmployeeName,
    sex=@sex,
    Birthday=@Birthday,
    Brief=@Brief
where EmployeeID=@EmployeeID 
go

exec UpdateEmployee '001','����',1,'1998-1-1','123'


--16
create procedure GetAllProduct
as
select * from TBL_Product
go

exec GetAllProduct
go


--17
create procedure InsertProduct
@ProductID nvarchar(6),
@ProductName nvarchar(80),
@SpellingCode nvarchar(40),
@Barcode nvarchar(14),
@Special nvarchar(40),
@Unit nvarchar(6),
@Origin nvarchar(50),
@CategoryID nvarchar(6),
@PurchasePrice decimal(18,2),
@SalePrice decimal(18,2),
@Quantity int
as
insert TBL_Product
values(@ProductID,@ProductName,@SpellingCode,@Barcode,@Special,@Unit,@Origin,@CategoryID,@PurchasePrice,@SalePrice,@Quantity)
go

exec InsertProduct '001','����','����','���','���','3','55','4',19.2,18.6,55
go

--18
create procedure DeleteProduct
@ProductID nvarchar(6)
as
delete TBL_Product
where ProductID=@ProductID
go

exec  DeleteProduct '001'
go

--19
create procedure FindProductByProductID
@ProductID nvarchar(6)
as
select * from  TBL_Product
where ProductID=@ProductID
go

exec FindProductByProductID '001'
go

--20
create procedure UpdateProduct
@ProductID nvarchar(6),
@ProductName nvarchar(80),
@SpellingCode nvarchar(40),
@Barcode nvarchar(14),
@Special nvarchar(40),
@Unit nvarchar(6),
@Origin nvarchar(50),
@CategoryID nvarchar(6),
@PurchasePrice decimal(18,2),
@SalePrice decimal(18,2),
@Quantity int
as
update TBL_Product
set ProductName=@ProductName,
    SpellingCode=@SpellingCode,
    Barcode=@Barcode,
    Special=@Special,
    Unit=@Unit,
    Origin=@Origin,
    CategoryID=@CategoryID,
    PurchasePrice=@PurchasePrice,
    SalePrice=@SalePrice,
    Quantity=@Quantity
where ProductID=@ProductID
go

exec UpdateProduct '001','����','����','��','�淶','3','55','4',19.2,18.6,55
go

--21
create procedure GetAllSupplier
as
select * from TBL_Supplier
go

exec GetAllSupplier
go

--22
create procedure InsertSupplier
@SupplierID nvarchar(6),
@SupplierName nvarchar(80),
@SpellingCode nvarchar(20),
@Address nvarchar(80),
@ZipCode char(6),
@Tel nvarchar(20),
@Fax nvarchar(20),
@BankName nvarchar(40),
@BankAccount nvarchar(50),
@Contacter nvarchar(20),
@Email nvarchar(30)
as
insert TBL_Supplier
values(@SupplierID,@SupplierName,@SpellingCode,@Address,@ZipCode,@Tel,@Fax,@BankName,@BankAccount,@Contacter,@Email)
go

exec  InsertSupplier '003','�Ӽ�','456','�ҹ���Һŷ�','54','123456','5544','�����','44','����','123@qq.com'
go

--23
create procedure DeleteSupplier
@SupplierID nvarchar(6)
as
delete TBL_Supplier
where SupplierID=@SupplierID
go

exec DeleteSupplier '003'
go

--24
create procedure FindSupplierBySupplierID
@SupplierID nvarchar(6)
as
select * from  TBL_Supplier
where SupplierID=@SupplierID
go

exec FindSupplierBySupplierID '003'
go

--25
create procedure UpdateSupplier
@SupplierID nvarchar(6),
@SupplierName nvarchar(80),
@SpellingCode nvarchar(20),
@Address nvarchar(80),
@ZipCode char(6),
@Tel nvarchar(20),
@Fax nvarchar(20),
@BankName nvarchar(40),
@BankAccount nvarchar(50),
@Contacter nvarchar(20),
@Email nvarchar(30)
as
update TBL_Supplier
set SupplierName=@SupplierName,
    SpellingCode =@SpellingCode,
    Address =@Address,
    ZipCode =@ZipCode,
    Tel =@Tel,
    Fax =@Fax ,
    BankName =@BankName ,
    BankAccount =@BankAccount,
    Contacter=@Contacter,
    Email=@Email 
where SupplierID=@SupplierID
go

exec UpdateSupplier '003','�Ӽ�','456','�ҹ���','34','123456','55','�����','44','����','123@qq.com'
go

--26�����ݱ�Ų�ѯ�������
create procedure FindPurchaseIDByPurchaseID
@PurchaseID nvarchar(12)
as
select PurchaseID from TBL_PurchaseBill
where PurchaseID like '%'+@PurchaseID+'%'
go

exec FindPurchaseIDByPurchaseID '2017'
go

--27��ҵ��Ա������ѯ�������
create procedure FindPurchaseIDByClerk
@EmployeeName nvarchar(80)
as
select PurchaseID from TBL_PurchaseBill as a inner join TBL_Employee as b on a.Clerk=b.EmployeeID
where b.EmployeeName like '%'+@EmployeeName+'%'
go

exec  FindPurchaseIDByClerk '����'
go

--28�����Ա������ѯ�������
create procedure FindPurchaseIDByExaminer
@EmployeeName nvarchar(80)
as
select PurchaseID from TBL_PurchaseBill as a inner join TBL_Employee as b on a.Examiner=b.EmployeeID
where b.EmployeeName like '%'+@EmployeeName+'%'
go

exec FindPurchaseIDByExaminer '����'
go

--29�����״̬��ѯ�������
create procedure FindPurchaseIDByOnProcess
@OnProcess smallint
as
select PurchaseID from TBL_PurchaseBill
where OnProcess=@OnProcess
go
 
exec FindPurchaseIDByOnProcess 0
go

--30���������ڲ�ѯ�������
create procedure FindPurchaseIDByPurchaseDate
@StartDate datetime,
@EndDate datetime
as
select PurchaseID from TBL_PurchaseBill
where PurchaseDate>=@StartDate and PurchaseDate<dateadd(day,1,@EndDate)
go

exec FindPurchaseIDByPurchaseDate '2019-08-08','2019-08-08'
go


--31���ݶ�����Ų�ѯһ�ʶ���
create procedure FindPurchaseBillByPurchaseID
@PurchaseID nvarchar(12)
as
select * from TBL_PurchaseBill
where PurchaseID=@PurchaseID
go

exec FindPurchaseBillByPurchaseID '201703100'
go

--32���ݶ�����Ų�ѯ�ö���������ϸ
alter procedure FindPurchaseDetailByPurchaseID
@PurchaseID nvarchar(12)
as
select * from TBL_PurchaseDetail
where PurchaseID=@PurchaseID
go

exec FindPurchaseDetailByPurchaseID '201703100'
go

--33��ƴ����ģ����ѯ��Ʒ��
create procedure FindProductBySpellingCode
@SpellingCode nvarchar(40)
as
select * from TBL_Product
where SpellingCode like @SpellingCode+'%'
go

exec FindProductBySpellingCode 'A'
go

--34
create procedure InsertPurchaseBill
@PurchaseID nvarchar(12),
@SupplierID nvarchar(6),
@PurchaseDate datetime,
@StockDate datetime,
@Clerk nvarchar(6),
@Examiner nvarchar(6),
@Custodian nvarchar(6),
@OnProcess smallint,
@memo nvarchar(100)
as
insert TBL_PurchaseBill
values(@PurchaseID ,@SupplierID,@PurchaseDate ,@StockDate ,@Clerk ,@Examiner ,@Custodian,@OnProcess,@memo)
go

exec InsertPurchaseBill '2017088001','002','2018-09-09','2019-09-09','002'	,'001'	,'001'	,'1',	NULL
go

---35

create procedure UpdatePurchaseBill
@PurchaseID nvarchar(12),
@SupplierID nvarchar(6),
@PurchaseDate datetime,
@StockDate datetime,
@Clerk nvarchar(6),
@Examiner nvarchar(6),
@Custodian nvarchar(6),
@OnProcess smallint,
@memo nvarchar(100)
as
update TBL_PurchaseBill
set SupplierID=@SupplierID,
PurchaseDate=@PurchaseDate ,
StockDate=@StockDate ,
Clerk=@Clerk ,
Examiner=@Examiner ,
Custodian=@Custodian,
OnProcess=@OnProcess,
memo=@memo
where PurchaseID=@PurchaseID
go

exec UpdatePurchaseBill '2017088001','002','2018-09-09','2019-09-09','002'	,'001'	,'001'	,'1',	NULL
go

---36
create procedure InsertPurchaseDetail
@PurchaseID nvarchar(12),
@PurchaseDetailID smallint,
@ProductID nvarchar(6),
@PurchasePrice decimal(18,2),
@Quantity int
as
insert TBL_PurchaseDetail
values(@PurchaseID,@PurchaseDetailID ,@ProductID ,@PurchasePrice ,@Quantity )
go

exec InsertPurchaseDetail '2017011011',1,'002',44,33
go


--37
create procedure DeletePurchaseDetailByPurchaseID
@PurchaseID nvarchar(12)
as
delete TBL_PurchaseDetail
where PurchaseID=@PurchaseID
go

exec DeletePurchaseDetailByPurchaseID '20180202001'
go

--38.����һ����ֵ����CreatePurchaseID��
--������@purchaseDate
--���ܣ����ݶ������ڣ����ض�����š����ݶ������ڣ���2014-4-5���Ȳ�ѯ������Ϣ��
--���������δ�µ����򶩵����Ϊ ������0001����201404050001����������������ж�����
--�򶩵����Ϊ��󶩵����+1��������8�ʶ���������Ϊ201404050009����

--create function fn_CreatePurchaseID
--(@purchaseDate datetime)
--returns nchar(12)
--as
--  begin
--  declare @PurchaseID nvarchar(12) ,@date nvarchar(10)
--  select @PurchaseID=right(cast(power(10,4) as varchar)+
--  (select count(*) from dbo.TBL_PurchaseBill 
--  where PurchaseID like (select CONVERT(varchar(100),@purchaseDate, 112))+'%')+1 ,4)   
--  Select @date=CONVERT(varchar(100), @purchaseDate, 112)
  
--  return  @date+@PurchaseID
--  end
--go

create function fn_CreatePurchaseID
(@purchaseDate datetime)
returns nchar(12)
as
  begin
  declare @date nvarchar(8),@maxPurchaseID nvarchar(12),@PurchaseID nvarchar(12)
  select @date= CONVERT(varchar(100),@purchaseDate,112)
  select @maxPurchaseID=max(PurchaseID) from TBL_PurchaseBill
  where PurchaseID like @date+'%'
  if(@maxPurchaseID is null)
     set @PurchaseID=@date+'0001'
  else
     set @PurchaseID=convert(nchar(12),convert(bigint,@maxPurchaseID)+1)
  
  return @PurchaseID
  end
go

select dbo.fn_CreatePurchaseID(GETDATE())
go

create procedure CreatePurchaseID
@purchaseDate datetime
as
 select dbo.fn_CreatePurchaseID(@PurchaseDate)
go

--39.	��TBL_Employee��������һ��Insert������Employee_insert
--���ܣ�����Ա����Ϣ���в���һ�м�¼ʱ��ͬʱ����Ա����Ϣ���뵽�û���Ϣ���У�useridΪԱ����emploeeid,
--����Ĭ��Ϊ666666��Ȩ��ֵ�ֱ�Ϊ0��0��0��1��
create trigger Employee_insert
  on TBL_Employee
  for INSERT
as
begin
  declare @EmployeeID nvarchar(40)
  select @EmployeeID=EmployeeID from inserted
  insert dbo.TBL_SystemUser
  values(@EmployeeID,'666666',0,0,0,1)
end
  go
  
  insert dbo.TBL_Employee
  values('00001', '����', 1,'1998-01-01', '123')
  go
   
--  40.	��TBL_Employee��������һ��Delete������Employee_delete
--���ܣ���Ա����Ϣ����ɾ��һ�м�¼ʱ��ͬʱ���û���Ϣ���ж�Ӧ�ļ�¼ɾ����
create trigger Employee_delete
 on TBL_Employee
  for DELETE
as
 begin
 declare @UserID nvarchar(6)
 select @UserID=EmployeeID from deleted
 delete dbo.TBL_SystemUser
 where UserID=@UserID
 end
 go
 
 select * from dbo.TBL_Employee
 delete dbo.TBL_Employee
 where EmployeeID='00001'
 go
 
select * from dbo.TBL_SystemUser
go


--41.	��TBL_PurchaseBill������һ��Update������purchaseBill_update
--���ܣ���TBL_PurchaseBill����ĳһ�ʶ�����onprocess��״̬��0����Ϊ2ʱ��
--��ʹ�øö�����Ӧ����ϸ��Ϣ���²�Ʒ��Ϣ���еĿ�桢�۸��ֶΡ�
create trigger purchaseBill_update
on TBL_PurchaseBill
   for UPDATE
as
  IF UPDATE(OnProcess)
  begin
  declare @oldOnProcess smallint,@newOnProcess smallint,@purchaseID nchar(12)
  select @oldOnProcess=OnProcess,@purchaseID=PurchaseID from deleted
  select @newOnProcess=OnProcess from inserted
  if(@oldOnProcess=0 and @newOnProcess=2)
  UPDATE p
  set p.Quantity=p.Quantity+d.Quantity,
      p.PurchasePrice=(p.PurchasePrice*p.Quantity+d.PurchasePrice*d.Quantity)/(p.Quantity+d.Quantity),
      p.SalePrice=(p.PurchasePrice*p.Quantity+d.PurchasePrice*d.Quantity)/(p.Quantity+d.Quantity)*1.5
      FROM TBL_Product as p inner join (select * from TBL_PurchaseDetail where PurchaseID=@purchaseID) as d
      on p.ProductID=d.ProductID 
  end
go


--42
create procedure GetAllSystemUser
as
select * from dbo.TBL_SystemUser
GO

exec GetAllSystemUser
go

--43
create procedure InsertSystemUser
@UserID nvarchar(6),
@Password nvarchar(10),
@BaseFunction int,
@PurchaseFunction int,
@SaleFunction int,
@UserFunction int
as
insert TBL_SystemUser
values(@UserID,@Password,@BaseFunction,@PurchaseFunction,@SaleFunction,@UserFunction)
go

exec InsertSystemUser 'adm','6666',31,0,0,3
go

--44
create procedure  DeleteSystemUser
@UserID nvarchar(6)
as
delete TBL_SystemUser
where UserID=@UserID
go


exec DeleteSystemUser 'adm'
go

--45
create procedure FindSystemUserByUserID
@UserID nvarchar(6)
as
select * from TBL_SystemUser
where UserID=@UserID
go

exec FindSystemUserByUserID 'admin'
go


--46
create procedure UpdateSystemUser
@UserID nvarchar(6),
@Password nvarchar(10),
@BaseFunction int,
@PurchaseFunction int,
@SaleFunction int,
@UserFunction int
as
update TBL_SystemUser
set Password=@Password,
BaseFunction=@BaseFunction,
PurchaseFunction=@PurchaseFunction,
SaleFunction=@SaleFunction,
UserFunction=@UserFunction
where UserID=@UserID
GO

exec UpdateSystemUser 'adm','6666',16,0,0,1
go


--47
create procedure GetCategoryByCategoryIDAndCategyName
@CategoryID nvarchar(6),
@CategoryName nvarchar(80)
as
select * from TBL_Category
where CategoryID=case @CategoryID when '' then CategoryID else @CategoryID end 
and CategoryName like '%' + @CategoryName+'%'
go

exec GetCategoryByCategoryIDAndCategyName '',''
go


--48
create procedure GetCustomerByCustomerIDAndCustomerName
@CustomerID nvarchar(6),
@CustomerName nvarchar(80)
as
select * from TBL_Customer
where  CustomerID=case @CustomerID when '' then CustomerID else @CustomerID end
and CustomerName like '%' + @CustomerName+'%'
go

exec GetCustomerByCustomerIDAndCustomerName '','��'
go


--49
create procedure GetEmployeeByEmployeeIDAndEmployeeName
@EmployeeID nvarchar(6),
@EmployeeName nvarchar(80)
as
select * from TBL_Employee
where EmployeeID=case @EmployeeID when '' then EmployeeID else @EmployeeID end
and EmployeeName like '%' + @EmployeeName+'%'
go

exec GetEmployeeByEmployeeIDAndEmployeeName '002',''
go

--50
create procedure GetProductByProductIDAndProductName
@ProductID nvarchar(6),
@ProductName nvarchar(80)
as
select * from TBL_Product
where ProductID=case @ProductID when '' then ProductID else @ProductID end
and ProductName like '%' + @ProductName+'%'
go

exec GetProductByProductIDAndProductName '003','��'
go

--51
create procedure GetSupplierBySupplierIDAndSupplierName
@SupplierID nvarchar(6),
@SupplierName nvarchar(80)
as
select * from TBL_Supplier
where SupplierID= case @SupplierID when '' then SupplierID else @SupplierID end
and SupplierName like '%' + @SupplierName+'%'
go

exec GetSupplierBySupplierIDAndSupplierName '001','��������'
go


--52
create procedure User_Login
@UserID nvarchar(6),
@Password nvarchar(10)
as
select COUNT(*) from TBL_SystemUser
where UserID=@UserID and Password=@Password
go

exec User_Login '003','666666'

