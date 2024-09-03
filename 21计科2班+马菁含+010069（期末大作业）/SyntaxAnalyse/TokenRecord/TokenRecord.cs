using System;
using System.Collections.Generic;
using System.Text;

//Author: Alex Leo
//Email: alexleo321@hotmail.com
//Blog: http://www.cnblogs.com/conexpress/

namespace ConExpress.Calculator
{
    /// <summary>
    /// �Ǻ�ֵ����ö��
    /// </summary>
    /// <remarks>Author:Alex Leo;</remarks>
    public enum TokenValueTypeEnum
    {
        /// <summary>
        /// �ַ���ֵ����
        /// </summary>
        String,
        /// <summary>
        /// ����ֵ����
        /// </summary>
        Number,
    }

    /// <summary>
    /// �����Ǻ�����ö��
    /// </summary>
    /// <remarks>Author:Alex Leo;</remarks>
    public enum OperateTokenTypeEnum
    {
        /// <summary>
        /// �ؼ���
        /// </summary>
        TokenKeyword,
        /// <summary>
        /// ����
        /// </summary>
        TokenSymbol,
    }

    /// <summary>
    /// �Ǻż�¼
    /// </summary>
    /// <remarks>Author:Alex Leo;</remarks>
    public abstract class TokenRecord
    {
        #region ���Ժ��ֶ�

        //�¼�����
        protected int m_ChildCount;

        private int m_Index;
        /// <summary>
        /// �����
        /// </summary>
        public int Index
        {
            get { return m_Index; }
        }

        /// <summary>
        /// ���ȼ������븳ֵ
        /// </summary>
        protected int m_Priority;
        /// <summary>
        /// ���ȼ�
        /// </summary>
        /// <returns></returns>
        public int Priority
        {
            get { return m_Priority; }
        }

        private int m_Length;
        /// <summary>
        /// ����������
        /// </summary>
        public int Length
        {
            get { return m_Length; }
        }

        private Type m_TokenValueType;
        /// <summary>
        /// �Ǻ�ֵ����
        /// </summary>
        public Type TokenValueType
        {
            get { return m_TokenValueType; }
            set { m_TokenValueType = value; }
        }

        private object m_TokenValue;
        /// <summary>
        /// �Ǻ�ֵ
        /// </summary>
        public object TokenValue
        {
            get { return m_TokenValue; }
            set { m_TokenValue = value; }
        }


        private List<TokenRecord> m_ChildList = new List<TokenRecord>();
        /// <summary>
        /// �¼��б�
        /// </summary>
        public List<TokenRecord> ChildList
        {
            get { return m_ChildList; }
        }

        #endregion

        /// <summary>
        /// ���캯��
        /// </summary>
        /// <param name="Index">���</param>
        /// <param name="Length">������</param>
        public TokenRecord(int Index, int Length)
        {
            this.m_Index = Index;
            this.m_Length = Length;
            this.SetPriority();
            this.SetChildCount();
        }


        #region ����

        /// <summary>
        /// ��дToString����
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //���Ը�����Ҫ�޸�����ʾ��ͬ����Ϣ
            return this.GetType().Name + "_" + GetValueString() + "_" + GetTypeName();
        }

        /// <summary>
        /// ��ȡֵ���ַ�����ʾ
        /// </summary>
        /// <returns></returns>
        public string GetValueString()
        {
            if (this.TokenValue == null)
                return "";
            else
                return this.TokenValue.ToString();
        }

        /// <summary>
        /// ��ȡ��������
        /// </summary>
        /// <returns></returns>
        public string GetTypeName()
        {
            if (this.TokenValueType == null)
                return "δ��ʼ������";
            else
                return this.TokenValueType.ToString();
        }

        /// <summary>
        /// ����¼���������Ҫʱ������д����Ϊ��ЩToken���¼�����������һ������
        /// </summary>
        /// <param name="ErrorInformation">�¼���������ʱ��ʾ�Ĵ�����Ϣ</param>
        internal void CheckChildCount(string ErrorInformation)
        {
            if (this.m_ChildList.Count != this.m_ChildCount)
                throw new SyntaxException(this.m_Index, this.m_Length, ErrorInformation);
        }

        #region ������д�ķ���

        /// <summary>
        /// ִ�д���
        /// </summary>
        public abstract void Execute();

        /// <summary>
        /// �����¼�����
        /// </summary>
        protected abstract void SetChildCount();

        /// <summary>
        /// �������ȼ�
        /// </summary>
        protected abstract void SetPriority();

        #endregion


        #endregion


        #region ת���Ǻ�ֵ����

        /// <summary>
        /// ���Ǻ�ֵת��Ϊ�ַ�������
        /// </summary>
        internal string ChangeTokenToString()
        {
            string strValue;
            strValue = (string)(this.TokenValue = (this.TokenValue != null ? this.TokenValue.ToString() : ""));
            this.TokenValueType = typeof(string);
            return strValue;
        }

        /// <summary>
        /// ���Ǻ�ֵת��Ϊ��������
        /// </summary>
        /// <param name="ErrorInformation">�޷�ת��������ʱ��ʾ�Ĵ�����Ϣ</param>
        internal double ChangeTokenToDouble(string ErrorInformation)
        {
            double dblValue;
            if (this.TokenValueType == typeof(string))
            {
                if (double.TryParse(this.TokenValue.ToString(), out dblValue))
                {
                    this.TokenValue = dblValue;
                    this.TokenValueType = typeof(double);
                }
                else
                    throw new SyntaxException(this.m_Index, this.m_Length, ErrorInformation);
            }
            else if (this.TokenValueType == typeof(bool))
            {
                try
                {
                    dblValue = Convert.ToDouble(this.TokenValue);
                    this.TokenValue = dblValue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    throw new SyntaxException(this.m_Index, this.m_Length, ErrorInformation);
                }
            }
            else
            {
                dblValue = Convert.ToDouble(this.TokenValue != null ? this.TokenValue : 0D);
                this.TokenValue = dblValue;
            }
            return dblValue;
        }

        /// <summary>
        /// ���Ǻ�ֵת��Ϊ�߼�ֵ
        /// </summary>
        internal bool ChangeTokenToBoolean()
        {
            this.TokenValueType = typeof(bool);
            bool blnValue = false;
            if (this.TokenValueType == typeof(string))
            {
                switch (this.TokenValue.ToString().Trim().ToLower())
                {
                    case "true":
                        blnValue = (bool)(this.TokenValue = true);
                        break;
                    case "false":
                    case "":
                    default:
                        blnValue = (bool)(this.TokenValue = false);
                        break;
                }
            }
            else if (this.TokenValueType == typeof(double))
            {
                blnValue = (bool)((Convert.ToInt32(this.TokenValue) != 0) ? (this.TokenValue = true) : (this.TokenValue = false));
                //�����һ�д����Ƿ����
            }
            else
            {
                blnValue = Convert.ToBoolean(this.TokenValue != null ? this.TokenValue : false);
                this.TokenValue = blnValue;
            }

            return blnValue;
        }

        #endregion

    }//class TokenRecord
}//namespace