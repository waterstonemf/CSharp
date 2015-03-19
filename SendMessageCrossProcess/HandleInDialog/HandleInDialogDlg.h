
// HandleInDialogDlg.h : header file
//

#pragma once
#include "afxwin.h"


// CHandleInDialogDlg dialog
class CHandleInDialogDlg : public CDialogEx
{
// Construction
public:
	CHandleInDialogDlg(CWnd* pParent = NULL);	// standard constructor

// Dialog Data
	enum { IDD = IDD_HANDLEINDIALOG_DIALOG };

	protected:
	virtual void DoDataExchange(CDataExchange* pDX);	// DDX/DDV support


// Implementation
protected:
	HICON m_hIcon;

	// Generated message map functions
	virtual BOOL OnInitDialog();
	afx_msg void OnSysCommand(UINT nID, LPARAM lParam);
	afx_msg void OnPaint();
	afx_msg HCURSOR OnQueryDragIcon();
	DECLARE_MESSAGE_MAP()
public:
	afx_msg void OnBnClickedBtnadd();
	CEdit editNumber1;
	CEdit editNumber2;
	CEdit editResult;
	CEdit editHandles;
};
