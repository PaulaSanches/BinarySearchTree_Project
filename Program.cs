using System;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BinarySearchTree
{
    class Node
    {
        public int value;
        public Node left;
        public Node right;
    }

    class Tree
    {
        static readonly int COUNT = 10; 

        // Function to create a new Node in heap
        public Node getNewNode(int data) 
        {
            Node newNode = new Node();
            newNode.value = data;
            newNode.left = newNode.right = null;
            return newNode;
        }
        // HeightTree
        public int heightTree (Node root) 
        {
            int leftHeight, rightHeight;

            if(root == null) { // empty tree
                return 0;
            }

            leftHeight = heightTree(root.left);
            rightHeight = heightTree(root.right);

            return Math.Max(leftHeight,rightHeight) + 1;	
        }


        //This algorithm finds the largest node in a BST
        // root is a pointer to a nonempty BST or subtree
        //return addres of largest node returned
        public Node findLargestBST(Node root) 
        {
	        if (root.right == null)
		        return root;

	        return findLargestBST(root.right);
        }
        public Node findSmallestBST(Node root) 
        {
            if (root.left == null)
            	return root;
    
        	return findSmallestBST(root.left);
        }


        public bool deleteBST (Node root, int dltKey)
        {
	        if(root == null) 
            { // empty tree
		        return false;
	        }
	
	        if (dltKey < root.value){
		        return deleteBST(root.left,dltKey);
	        } else if (dltKey > root.value){
		        return deleteBST(root.right,dltKey);
	        } 
            else 
            {
		        if (root.left == null) 
                {
			        root = root.right;
			        return true;
		        } else if (root.right == null) 
                {
			        root = root.left;
			        return true;		
		        }
		        else 
                {
			        // save root in deleteNode
			        root = findLargestBST(root.left); // set largest to largestBST (left subtree)
			        //root = root.left;
			        // move data in largest to deleteNode
			        return deleteBST(root.left,root.value);
		        }
	        }
        }

        // To insert data in BST, returns address of root node 
        public Node addBST(Node root,int data)
        {
            if(root == null) 
            { // empty tree
                root = getNewNode(data);
            }
            // if data to be inserted is lesser, insert in left subtree. 
            else if(data <= root.value) 
            {
                root.left = addBST(root.left,data);
            }
            // else, insert in right subtree. 
            else 
            {
                root.right = addBST(root.right,data);
            }
            
            return root;            
        }

        //To search an element in BST, returns true if element is found
        public Node searchBST(Node root,int targetKey) 
        {
	        if(root == null) 
            {
		        return null;
	        }
	
	        if(targetKey < root.value) 
            {
		        return searchBST(root.left,targetKey);
	        }
	        else if (targetKey > root.value) 
            {
		        return searchBST(root.right,targetKey);
	        }
	        else 
            {
		        return root;
	        }
        }

        // Function to print binary tree in 2D 
        // It does reverse inorder traversal 
        public void print2DUtil(Node root, int space) 
        { 
            // Base case 
            if (root == null) 
                return; 
  
            // Increase distance between levels 
            space += COUNT; 
  
            // Process right child first 
            print2DUtil(root.right, space); 
  
            // Print current node after space 
            // count 
            Console.Write("\n"); 
            for (int i = COUNT; i < space; i++) 
                Console.Write(" "); 
            Console.Write(root.value + "\n"); 
  
            // Process left child 
            print2DUtil(root.left, space); 
        } 
  
        // Wrapper over print2DUtil() 
        public void print2D(Node root) 
        { 
            // Pass initial space count as 0 
            print2DUtil(root, 0); 
        } 



    }


    class BinarySearchTree
    {
        static void Main(string[] args)
        {
            Node root = null;
            Tree bst = new Tree();
            int n = 10000;
            int[] a = new int[n];

            Console.WriteLine("Generating random array with {0} values...", n);

            Random random = new Random();


            Stopwatch watch = Stopwatch.StartNew();

            for (int i = 0; i < n; i++)
            {
                a[i] = random.Next(1,n);
            }

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();
            Console.WriteLine("Filling the tree with {0} nodes...", n);

            watch = Stopwatch.StartNew();

            for (int i = 0; i < n; i++)
            {
                root = bst.addBST(root, a[i]);
            }

            watch.Stop();

            Console.WriteLine("Done. Took {0} seconds", (double)watch.ElapsedMilliseconds / 1000.0);
            Console.WriteLine();

            Console.WriteLine("Deleting the node {0}...", 100);
            if(bst.deleteBST(root,100))
                Console.WriteLine("100 deleted!...");
            else
                Console.WriteLine("100 NOT FOUND!...");
            Console.WriteLine();

            Console.WriteLine("height tree {0}...", bst.heightTree(root));


            // print the tree
            bst.print2D(root);     

        }
    }
}
