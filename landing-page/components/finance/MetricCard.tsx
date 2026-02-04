/**
 * JERP 3.0 - Payroll & ERP System
 * Copyright (c) 2026 ninoyerbas. All Rights Reserved.
 * 
 * PROPRIETARY AND CONFIDENTIAL
 * 
 * Unauthorized copying, modification, distribution, or use is strictly prohibited.
 * For licensing inquiries: licensing@jerp.io
 */

interface MetricCardProps {
  title: string;
  value: string | number;
  change?: string;
  icon: string;
  color: string;
}

export function MetricCard({ title, value, change, icon, color }: MetricCardProps) {
  const isPositive = change && change.startsWith('+');
  const isNegative = change && change.startsWith('-');
  
  return (
    <div style={{
      background: "linear-gradient(135deg, rgba(30, 41, 59, 0.9) 0%, rgba(15, 23, 42, 0.9) 100%)",
      borderRadius: "12px",
      padding: "24px",
      border: "1px solid rgba(71, 85, 105, 0.3)",
      boxShadow: "0 4px 6px rgba(0, 0, 0, 0.1)",
    }}>
      <div style={{ 
        display: "flex", 
        alignItems: "center", 
        justifyContent: "space-between", 
        marginBottom: "16px" 
      }}>
        <span style={{ 
          fontSize: "14px", 
          color: "#94a3b8", 
          fontWeight: "500",
          textTransform: "uppercase",
          letterSpacing: "0.05em"
        }}>
          {title}
        </span>
        <div style={{ fontSize: "24px" }}>{icon}</div>
      </div>
      <div style={{ 
        fontSize: "32px", 
        fontWeight: "700", 
        color: "#f1f5f9", 
        marginBottom: "8px",
        fontVariantNumeric: "tabular-nums"
      }}>
        {value}
      </div>
      {change && (
        <div style={{ 
          fontSize: "12px", 
          color: isPositive ? "#10b981" : isNegative ? "#ef4444" : "#94a3b8",
          fontWeight: "500"
        }}>
          {change}
        </div>
      )}
    </div>
  );
}
