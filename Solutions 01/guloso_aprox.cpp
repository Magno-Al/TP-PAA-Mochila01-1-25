#include <iostream>
#include <vector>
#include <string>
#include <sstream>
#include <cstdlib>
#include <algorithm>

struct Item {
    int id;
    int value;
    int weight;
    double density;
};

bool compareItems(const Item& a, const Item& b) {
    return a.density > b.density;
}

int knapsack(int W, std::vector<int>& val, std::vector<int>& wt) {
    int n = val.size();
    std::vector<Item> items(n);

    for (int i = 0; i < n; i++) {
        items[i].id = i;
        items[i].value = val[i];
        items[i].weight = wt[i];
        if (wt[i] != 0) {
            items[i].density = (double)val[i] / wt[i];
        } else {
            items[i].density = 0;
        }
    }

    std::sort(items.begin(), items.end(), compareItems);

    int currentWeight = 0;
    int finalValue = 0;

    for (int i = 0; i < n; i++) {
        if (currentWeight + items[i].weight <= W) {
            // Adiciona o item
            currentWeight += items[i].weight;
            finalValue += items[i].value;
        }
    }

    return finalValue;
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