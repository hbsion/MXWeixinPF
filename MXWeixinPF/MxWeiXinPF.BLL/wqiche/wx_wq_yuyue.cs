﻿using System;
using System.Data;
using System.Collections.Generic;
using MxWeiXinPF.Common;
using MxWeiXinPF.Model;
namespace MxWeiXinPF.BLL
{
	/// <summary>
	/// wx_wq_yuyue
	/// </summary>
	public partial class wx_wq_yuyue
	{
		private readonly MxWeiXinPF.DAL.wx_wq_yuyue dal=new MxWeiXinPF.DAL.wx_wq_yuyue();
		public wx_wq_yuyue()
		{}
		#region  BasicMethod

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(MxWeiXinPF.Model.wx_wq_yuyue model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(MxWeiXinPF.Model.wx_wq_yuyue model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.Delete();
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public MxWeiXinPF.Model.wx_wq_yuyue GetModel()
		{
			//该表无主键信息，请自定义主键/条件字段
			return dal.GetModel();
		}

		 

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<MxWeiXinPF.Model.wx_wq_yuyue> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<MxWeiXinPF.Model.wx_wq_yuyue> DataTableToList(DataTable dt)
		{
			List<MxWeiXinPF.Model.wx_wq_yuyue> modelList = new List<MxWeiXinPF.Model.wx_wq_yuyue>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				MxWeiXinPF.Model.wx_wq_yuyue model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

