WITH RECURSIVE tree AS (

    SELECT node_id, parent_id, node_name, 1 AS level
    FROM Program_Tree
    WHERE parent_id IS NULL
    
    UNION ALL

    SELECT t.node_id, t.parent_id, t.node_name, tree.level + 1
    FROM Program_Tree t
    JOIN tree ON t.parent_id = tree.node_id
)
SELECT * FROM tree;