# Write your MySQL query statement below
# Write your MySQL query statement below
WITH cte AS (SELECT 
d.name AS Department,
e.name AS Employee,
e.salary AS Salary,
DENSE_RANK() OVER(PARTITION BY d.name ORDER BY e.salary DESC) AS rank_hs
FROM employee e
JOIN department d
ON e.departmentid = d.id
)

SELECT
Department,
Employee,
Salary
FROM cte
WHERE rank_hs <=3;