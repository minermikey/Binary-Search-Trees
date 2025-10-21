# Binary Search Tree in C#

A simple console-based **Binary Search Tree (BST)** implementation written in **C#**.
This project demonstrates the core operations of a binary tree — such as **insertion**, **deletion**, **searching**, and different **tree traversals** — using recursion.

---

## What Is a Binary Search Tree?

A **Binary Search Tree** is a data structure where:

* Each node contains a **value**, a **left child**, and a **right child**.
* **Left child values** are *less than* the parent node.
* **Right child values** are *greater than* the parent node.

This structure allows efficient **search**, **insert**, and **delete** operations, typically in **O(log n)** time.

---

## Features

* ✅ Insert new nodes
* 🔍 Search for values
* 🗑️ Delete nodes (with 0, 1, or 2 children)
* 🔄 Traversals:

  * In-order (Left → Root → Right)
  * Pre-order (Root → Left → Right)
  * Post-order (Left → Right → Root)
* 🌲 Visual text-based tree display

---

## Project Structure

```
BinarySearchTreeDemo/
├── Program.cs          # Main entry point
├── BinaryTree.cs       # Contains logic for Insert, Delete, Search, Traversals, Print
├── TreeNode.cs         # Node structure class
├── BinarySearchTreeDemo.csproj
└── README.md
```

---

## How to Run

1. **Clone this repository:**

   ```bash
   git clone [(https://github.com/minermikey/Binary-Search-Trees.git)]
   cd BinarySearchTreeDemo
   ```

2. **Build and run the project:**

   ```bash
   dotnet run
   ```

3. You’ll see output like:

   ```
   🌳 Binary Tree (Visual View):
   ├── 50
   │   ├── 30
   │   │   ├── 20
   │   │   └── 40
   │   └── 70
   │       ├── 60
   │       └── 80

   In-order Traversal:
   20 30 40 50 60 70 80
   ```

---

## Learn More

This project was built as a learning exercise to understand:

* Recursion
* Tree data structures
* Generic classes (`where T : IComparable<T>`)
* Console applications in C#
