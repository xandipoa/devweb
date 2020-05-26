--Criando uma Tabela para exemplicar a Procedure
Create Table Cidade
( 
codigo Int Identity(1,1) Primary Key Not Null,
nome varchar(50),
uf varchar(2)
);

--Incluindo dados para teste
insert into Cidade values ('Guarulhos', 'SP'), ('Osaco', 'SP'), ('Suzano', 'SP'), ('Jaguarão', 'RS'), ('Esteio', 'RS'), ('Betim', 'MG');

--Criação da Procedure
GO
CREATE PROCEDURE CIDADE_UF 
AS
Begin
Select uf, COUNT(uf) from Cidade
group by uf;
end

--Testando a Procedure
EXEC CIDADE_UF