'use client';

import { motion } from 'framer-motion';
import { DollarSign, Users, TrendingUp, Gift, BookOpen, Zap } from 'lucide-react';
import Link from 'next/link';

export default function PartnersPage() {
  return (
    <div className="min-h-screen bg-gradient-to-br from-slate-900 via-slate-800 to-slate-900">
      {/* Hero Section */}
      <section className="relative min-h-screen flex items-center justify-center px-4 py-20">
        <div className="absolute inset-0 bg-gradient-to-br from-red-500/10 via-transparent to-blue-500/10" />
        
        <div className="relative max-w-6xl mx-auto text-center">
          <motion.div
            initial={{ opacity: 0, y: 20 }}
            animate={{ opacity: 1, y: 0 }}
            className="inline-flex items-center gap-2 bg-red-500/10 border border-red-500/20 rounded-full px-4 py-2 mb-8"
          >
            <span className="w-2 h-2 bg-red-500 rounded-full animate-pulse" />
            <span className="text-sm text-red-400">Programa de Socios Profesionales</span>
          </motion.div>

          <motion.h1
            initial={{ opacity: 0, y: 20 }}
            animate={{ opacity: 1, y: 0 }}
            transition={{ delay: 0.1 }}
            className="text-5xl md:text-7xl font-bold text-white mb-6 leading-tight"
          >
            Gana{' '}
            <span className="text-transparent bg-clip-text bg-gradient-to-r from-red-500 to-orange-500">
              25-35%
            </span>
            <br />
            de Comisión Recurrente
          </motion.h1>

          <motion.p
            initial={{ opacity: 0, y: 20 }}
            animate={{ opacity: 1, y: 0 }}
            transition={{ delay: 0.2 }}
            className="text-xl text-slate-300 mb-12 max-w-3xl mx-auto"
          >
            Únete al programa de socios de JERP y obtén ingresos recurrentes recomendando 
            nuestro software de nómina a tus clientes. Perfecto para contadores, 
            asesores fiscales y consultores de RRHH.
          </motion.p>

          <motion.div
            initial={{ opacity: 0, y: 20 }}
            animate={{ opacity: 1, y: 0 }}
            transition={{ delay: 0.3 }}
            className="flex gap-4 justify-center"
          >
            <Link
              href="/partners/signup"
              className="px-8 py-4 bg-gradient-to-r from-red-500 to-orange-500 text-white rounded-lg font-semibold hover:shadow-lg hover:shadow-red-500/50 transition-all"
            >
              Aplicar Ahora
            </Link>
            <Link
              href="/partners/login"
              className="px-8 py-4 border border-slate-600 text-white rounded-lg font-semibold hover:bg-slate-800 transition-all"
            >
              Iniciar Sesión
            </Link>
          </motion.div>
        </div>
      </section>

      {/* Benefits Section */}
      <section className="py-20 px-4">
        <div className="max-w-6xl mx-auto">
          <h2 className="text-4xl font-bold text-white text-center mb-16">
            Beneficios del Programa
          </h2>

          <div className="grid md:grid-cols-3 gap-8">
            <motion.div
              initial={{ opacity: 0, y: 20 }}
              whileInView={{ opacity: 1, y: 0 }}
              viewport={{ once: true }}
              className="bg-slate-800/50 border border-slate-700 rounded-xl p-8"
            >
              <DollarSign className="w-12 h-12 text-red-500 mb-4" />
              <h3 className="text-2xl font-bold text-white mb-4">Comisiones Recurrentes</h3>
              <p className="text-slate-300">
                Gana del 25% al 35% de comisión mensual recurrente por cada cliente que refieras, 
                más bonos de $75-$125 por registro.
              </p>
            </motion.div>

            <motion.div
              initial={{ opacity: 0, y: 20 }}
              whileInView={{ opacity: 1, y: 0 }}
              viewport={{ once: true }}
              transition={{ delay: 0.1 }}
              className="bg-slate-800/50 border border-slate-700 rounded-xl p-8"
            >
              <TrendingUp className="w-12 h-12 text-red-500 mb-4" />
              <h3 className="text-2xl font-bold text-white mb-4">Sistema de Niveles</h3>
              <p className="text-slate-300">
                Aumenta tus comisiones automáticamente: Bronce (25%), Plata (30%), Oro (35%) 
                según tu número de clientes activos.
              </p>
            </motion.div>

            <motion.div
              initial={{ opacity: 0, y: 20 }}
              whileInView={{ opacity: 1, y: 0 }}
              viewport={{ once: true }}
              transition={{ delay: 0.2 }}
              className="bg-slate-800/50 border border-slate-700 rounded-xl p-8"
            >
              <Gift className="w-12 h-12 text-red-500 mb-4" />
              <h3 className="text-2xl font-bold text-white mb-4">Materiales de Marketing</h3>
              <p className="text-slate-300">
                Acceso completo a recursos de marketing, plantillas de email, gráficos 
                para redes sociales y guías de ventas.
              </p>
            </motion.div>

            <motion.div
              initial={{ opacity: 0, y: 20 }}
              whileInView={{ opacity: 1, y: 0 }}
              viewport={{ once: true }}
              transition={{ delay: 0.3 }}
              className="bg-slate-800/50 border border-slate-700 rounded-xl p-8"
            >
              <BookOpen className="w-12 h-12 text-red-500 mb-4" />
              <h3 className="text-2xl font-bold text-white mb-4">Academia de Socios</h3>
              <p className="text-slate-300">
                Capacitación completa sobre el producto, técnicas de ventas y 
                mejores prácticas de socios exitosos.
              </p>
            </motion.div>

            <motion.div
              initial={{ opacity: 0, y: 20 }}
              whileInView={{ opacity: 1, y: 0 }}
              viewport={{ once: true }}
              transition={{ delay: 0.4 }}
              className="bg-slate-800/50 border border-slate-700 rounded-xl p-8"
            >
              <Users className="w-12 h-12 text-red-500 mb-4" />
              <h3 className="text-2xl font-bold text-white mb-4">Soporte Dedicado</h3>
              <p className="text-slate-300">
                Equipo de soporte exclusivo para socios, demos personalizadas y 
                ayuda para cerrar ventas.
              </p>
            </motion.div>

            <motion.div
              initial={{ opacity: 0, y: 20 }}
              whileInView={{ opacity: 1, y: 0 }}
              viewport={{ once: true }}
              transition={{ delay: 0.5 }}
              className="bg-slate-800/50 border border-slate-700 rounded-xl p-8"
            >
              <Zap className="w-12 h-12 text-red-500 mb-4" />
              <h3 className="text-2xl font-bold text-white mb-4">Panel de Control</h3>
              <p className="text-slate-300">
                Dashboard en tiempo real con tracking de referidos, comisiones, 
                y estadísticas de rendimiento.
              </p>
            </motion.div>
          </div>
        </div>
      </section>

      {/* Commission Structure */}
      <section className="py-20 px-4 bg-slate-800/30">
        <div className="max-w-4xl mx-auto">
          <h2 className="text-4xl font-bold text-white text-center mb-16">
            Estructura de Comisiones
          </h2>

          <div className="grid md:grid-cols-3 gap-6">
            <div className="bg-slate-800 border border-slate-700 rounded-xl p-8 text-center">
              <div className="text-3xl font-bold text-orange-400 mb-2">🥉 BRONCE</div>
              <div className="text-lg text-slate-400 mb-4">0-5 clientes</div>
              <div className="text-4xl font-bold text-white mb-2">25%</div>
              <div className="text-sm text-slate-400 mb-4">comisión recurrente</div>
              <div className="text-2xl font-bold text-red-400">$75</div>
              <div className="text-sm text-slate-400">bono por registro</div>
            </div>

            <div className="bg-gradient-to-br from-slate-700 to-slate-800 border-2 border-red-500 rounded-xl p-8 text-center transform scale-105">
              <div className="text-3xl font-bold text-gray-300 mb-2">🥈 PLATA</div>
              <div className="text-lg text-slate-400 mb-4">6-15 clientes</div>
              <div className="text-4xl font-bold text-white mb-2">30%</div>
              <div className="text-sm text-slate-400 mb-4">comisión recurrente</div>
              <div className="text-2xl font-bold text-red-400">$100</div>
              <div className="text-sm text-slate-400">bono por registro</div>
            </div>

            <div className="bg-slate-800 border border-slate-700 rounded-xl p-8 text-center">
              <div className="text-3xl font-bold text-yellow-400 mb-2">🥇 ORO</div>
              <div className="text-lg text-slate-400 mb-4">16+ clientes</div>
              <div className="text-4xl font-bold text-white mb-2">35%</div>
              <div className="text-sm text-slate-400 mb-4">comisión recurrente</div>
              <div className="text-2xl font-bold text-red-400">$125</div>
              <div className="text-sm text-slate-400">bono por registro</div>
            </div>
          </div>

          <div className="mt-12 bg-slate-800/50 border border-slate-700 rounded-xl p-8">
            <h3 className="text-2xl font-bold text-white mb-4">Ejemplo de Ingresos</h3>
            <p className="text-slate-300 mb-4">
              Un socio Plata con 10 clientes en el plan Pro ($109/mes promedio) ganaría:
            </p>
            <div className="grid md:grid-cols-2 gap-6">
              <div>
                <div className="text-sm text-slate-400">Comisión mensual recurrente</div>
                <div className="text-3xl font-bold text-white">$327</div>
                <div className="text-sm text-slate-400">($109 × 30% × 10 clientes)</div>
              </div>
              <div>
                <div className="text-sm text-slate-400">Ingreso anual estimado</div>
                <div className="text-3xl font-bold text-white">$3,924</div>
                <div className="text-sm text-slate-400">+ bonos de registro</div>
              </div>
            </div>
          </div>
        </div>
      </section>

      {/* CTA Section */}
      <section className="py-20 px-4">
        <div className="max-w-4xl mx-auto text-center">
          <h2 className="text-4xl font-bold text-white mb-6">
            ¿Listo para Comenzar?
          </h2>
          <p className="text-xl text-slate-300 mb-8">
            Únete a nuestra red de socios y comienza a generar ingresos recurrentes hoy.
          </p>
          <Link
            href="/partners/signup"
            className="inline-block px-12 py-4 bg-gradient-to-r from-red-500 to-orange-500 text-white rounded-lg font-semibold text-lg hover:shadow-lg hover:shadow-red-500/50 transition-all"
          >
            Aplicar al Programa de Socios
          </Link>
        </div>
      </section>
    </div>
  );
}
