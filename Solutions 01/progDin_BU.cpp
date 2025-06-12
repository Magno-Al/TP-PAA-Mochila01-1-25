#include <iostream>
#include <vector>
#include <string>
#include <sstream>
#include <cstdlib>
#include <algorithm>

int knapsack(int W, std::vector<int>& val, std::vector<int>& wt) {
    int n = val.size();
    std::vector<std::vector<int>> dp(n + 1, std::vector<int>(W + 1, 0));
    for (int i = 1; i <= n; i++) {
        for (int j = 1; j <= W; j++) {
            if (wt[i - 1] <= j) {
                dp[i][j] = std::max(val[i - 1] + dp[i - 1][j - wt[i - 1]], dp[i - 1][j]);
            } else {
                dp[i][j] = dp[i - 1][j];
            }
        }
    }
    return dp[n][W];
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