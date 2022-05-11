/****** Script for SelectTopNRows command from SSMS  ******/
SELECT 
      c.[Name] AS category
      ,p.Title AS product
  FROM Categories c
  LEFT JOIN Products p
  ON (p.CategoryID = c.ID)
