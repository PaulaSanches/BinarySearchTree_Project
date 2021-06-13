# BinarySearchTree_Project
 Implementation of  a Binary Search Tree in C# using random data.
 
PERFORMANCE 

The best running time occurs when the binary search tree is full – in which case the search processes used by the algorithms perform like a binary search. A full binary tree is one in which nodes completely fill every level. Just one more concept to understand the worst and average cases, a full binary search tree is said to be balanced because all node's proper descendants are divided evenly between its left and right subtrees. 

The depth of a binary search tree with n nodes can be no less than log(n) and so the running time of the find, insert and delete algorithms can be no less than log(n).   If the binary search tree becomes more and more unbalanced, the performance of the find, insert and delete algorithms degrades until reaching the worst case of O(n), where n is the number of nodes in the tree.   

The average time of a binary search tree which is constructed through a random sequence of insertions is O(log n).

TIME COMPLEXITY

AVERAGE - Access, Insertion, Search, Deletion -  Θ (log (n))
WORST - Access, Insertion, Search, Deletion - O (n)

SPACE COMPLEXITY

WORST - O (n)


APPLICATIONS LIST  

Binary search trees are used in many search applications where data is constantly coming in/out, such as “map” objects and “set” in multi-language libraries.    

Binary space partitioning, which is a BST used in almost all 3D video games to determine which objects need to be rendered. BSP trees are often used by 3D video games, particularly first-person shooters and those with indoor environments.   

Binary Trees are used on almost all high-bandwidth routers to store router tables as Binary Attempts.  

Hash Trees which is another type of binary tree used in p2p programs and specialized image signatures where a hash needs to be checked but the entire file is not available.   

Heaps - Used in implementing efficient priority queues, which in turn are used to schedule processes in many operating systems, quality of service in routers, and A* (path location algorithm used in AI applications including robotics and video games). Also used in heap-sort.   

Huffman coding is used in compression algorithms such as those used in .jpeg and .mp3 file formats.   

The GGM tree is used in cryptographic applications to generate a tree of pseudo-random numbers. Syntax tree - Built by compilers and (implicitly) calculators to parse expressions.   

Treap is a randomized binary search tree used in wireless networks and memory allocation. 

