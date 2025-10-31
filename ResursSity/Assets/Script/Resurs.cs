using System;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

namespace Resource
{
    public enum Res { tree, iron , med , boart, coverage , pipes, musket, boiler };
    public class Resurs : MonoBehaviour
    {
        

        [SerializeField] TextMeshProUGUI textMeshProTree;
        [SerializeField] TextMeshProUGUI textMeshProIron;
        [SerializeField] TextMeshProUGUI textMeshProMed;
        int tree = 50;
       // Тут просто начситены цыфры для того чтобы проверить магазин.
        int iron =10;
        int med;

        [SerializeField] TextMeshProUGUI textMeshProBoart;
        [SerializeField] TextMeshProUGUI textMeshProCoverage;
        [SerializeField] TextMeshProUGUI textMeshProPipes;
        int board;
        int coverage;
        int pipes;


        public void UpdadeTreeResurs(int res)
        {
            tree += res;
            Debug.Log("Дерево");
            textMeshProTree.text = (tree).ToString();
        }

        public void UpdadeIronResurs(int res)
        {
            iron += res;
            Debug.Log("Метал");
            textMeshProIron.text = (iron).ToString();
            
        }

        public void UpdadeMedResurs(int res)
        {
            med += res;
            Debug.Log("Медь");
            textMeshProMed.text = (med).ToString();
        }
        
        public bool ChekTreeCount(int need)
        {
            return tree >= need;
        }

        public void UpdateBoardResurs(int res)
        {
            board = res;
            Debug.Log("Доски");
            Debug.Log(board);
            textMeshProBoart.text = (board).ToString();
        }


        public bool ChekIronCount(int need)
        {
            return iron >= need;

        }
        public void UpdateCoverageResurs(int res)
        {
            coverage = res;
            Debug.Log("Обшивка");
            textMeshProCoverage.text = (coverage).ToString();
        }

        public bool CheMedCount(int need)
        {
            return med >= need;

        }
        public void UpdatePipeseResurs(int res)
        {
            pipes = res;
            Debug.Log("Трубы");
            textMeshProPipes.text = (pipes).ToString(); 
        }

        public void ChangeRes(string nameRes, int resPlus)
        {
            switch (nameRes)
            {
                case "tree":
                    UpdadeTreeResurs(resPlus);
                    break;

                case "iron":
                    UpdadeIronResurs(resPlus);
                    break;

                case "med":
                    UpdadeMedResurs(resPlus);
                    break;
            }
        }

        public bool IsCanSell(string nameRes, int count)
        {
            switch (nameRes)
            {
                case "tree":
                    return tree >= count;

                case "iron":
                    return iron >= count;

            }
            return false;
        }




        
    }
}