#include <iostream>
#include <bits/stdc++.h>

using namespace std;

bool existsInArray(int x, queue<int> y);

int main()
{
    // Contains neighbours that are next in queue to be visited
    queue<int> toBeVisited;
    // Contains the nodes we have visited
    bool visited[6];
    // Stores the shortest distances
    int distances[] = {2,3,4,4,2,1};
    // Contains infornmation about a node in a row
    int graph[6][4] = {{1,2,0,0},
                        {0,2,3,0},
                        {0,1,3,4},
                        {1,2,4,5},
                        {2,3,0,0},
                        {3,0,0,0}};
    // Contains the number of neighbours for each node
    int neighbours[6];

    int currentNode, currentNeighbour;

    //INITIALISATION
    for (int i = 0; i < 6; i++){
        visited[i] = false;
        // -1 corresponds to Infinity
        distances[i] = -1;
    }

    //INPUT
//    for (int i = 0; i < 6; i++){
//            cin >> neighbours[i];
//            for (int j = 0; j < neighbours[i]; i++){
//                cin >> graph[i][j];
//            }
//    }

    distances[0] = 0;
    toBeVisited.push(0);

    while (!toBeVisited.empty()) {
        currentNode = toBeVisited.front();
        toBeVisited.pop();
        visited[currentNode] = true;
        for (int i = 0; i < neighbours[currentNode]; i++)
        {
            currentNeighbour = graph[currentNode][i];
            if (visited[currentNeighbour] == false && !existsInArray(currentNeighbour, toBeVisited)){
                    toBeVisited.push(currentNeighbour);
            }
        }
        for (int i = 0; i < neighbours[currentNode]; i++)
        {
            currentNeighbour = graph[currentNode][i];
            if (distances[currentNeighbour] == -1 || distances[currentNeighbour] > (distances[currentNode] + 1)){
                    distances[currentNeighbour] = distances[currentNeighbour] + 1;
            }
        }
    }

    //OUTPUT
    for(int i = 0; i < 6; i++){
        cout << i+1 << " Node: " << distances[i] << endl;
    }
    return 0;
}

bool existsInArray(int x, queue<int> y){
    for (unsigned int i = 0; i < y.size(); i++){
        if(y.front() == x){return true;}
        y.pop();
    }
    return false;
}
