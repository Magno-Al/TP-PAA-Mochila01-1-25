#include <iostream>
#include <vector>
#include <string>
#include <sstream>
#include <cstdlib>
#include <algorithm>

int knapsackRec(int W, std::vector<int>& val, std::vector<int>& wt, int n) {
    if (n == 0 || W == 0) 
        return 0;
    if (wt[n - 1] > W) 
        return knapsackRec(W, val, wt, n - 1);
    else 
        return std::max(val[n - 1] + knapsackRec(W - wt[n - 1], val, wt, n - 1), knapsackRec(W, val, wt, n - 1));
}

int knapsack(int W, std::vector<int>& val, std::vector<int>& wt) {
    return knapsackRec(W, val, wt, val.size());
}

int main(int argc, char* argv[]) {
    if (argc < 4) {
        std::cerr << "ERRO: Argumentos insuficientes. Uso: <programa> <capacidade> <num_itens> <lista_itens>" << std::endl;
        return 1;
    }

    try {
        int W = std::stoi(argv[1]);
        int n = std::stoi(argv[2]);

        std::vector<int> val;
        std::vector<int> wt;
        std::string items_str = argv[3];
        std::stringstream ss(items_str);
        std::string item_pair;

        while (std::getline(ss, item_pair, ';')) {
            std::stringstream item_ss(item_pair);
            std::string value_str, weight_str;

            if (std::getline(item_ss, value_str, ',') && std::getline(item_ss, weight_str)) {
                val.push_back(std::stoi(value_str));
                wt.push_back(std::stoi(weight_str));
            }
        }

        if (val.size() != n) {
            std::cerr << "ERRO: O numero de itens na lista (" << val.size() << ") nao corresponde ao informado (" << n << ")." << std::endl;
            return 1;
        }

        int result = knapsack(W, val, wt);
        std::cout << "Valor Solucao: " << result << std::endl;

    } catch (const std::exception& e) {
        std::cerr << "ERRO durante o processamento dos argumentos: " << e.what() << std::endl;
        return 1;
    }

    return 0;
}