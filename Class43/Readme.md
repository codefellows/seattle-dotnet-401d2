# ![cf](http://i.imgur.com/7v5ASc8.png) Class 43: Azure Blob Storage

# Assignments

## Readings
- [Azure Blob](https://docs.microsoft.com/en-us/azure/visual-studio/vs-storage-aspnet-core-getting-started-blobs)
- [Getting Started](https://docs.microsoft.com/en-us/azure/storage/blobs/storage-dotnet-how-to-use-blobs)


## Code Challenge

### Number of Paths through an M x N grid

You are given two numbers, `M` and `N`.
They will always be >= 2.
Write a function that takes those two numbers as arguments and returns to you the number of possible paths through an M x N grid, starting at the top left and exiting at the bottom right.
You can only move down or to the right

**Stretch**: In addition to `M` and `N` you're passed a list of blocked boxes in the grid. You cannot travel into those boxes. How many paths are there now? If the starting or ending boxes are blocked, there are 0 paths.

```
(m=2, n=2):
    [ ][ ]
    [ ][ ]
2 paths

(m=2, n=5):
    [ ][ ][ ][ ][ ]
    [ ][ ][ ][ ][ ]
5 paths

(m=3, n=3):
    [ ][ ][ ]
    [ ][ ][ ]
    [ ][ ][ ]
6 paths
```